using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;

namespace Sonneville.Google
{
    public static class GoogleOAuth
    {
        public static UserCredential CreateCredential(string oauthClientIdPath, string tokenFullPath, IEnumerable<string> scopes)
        {
            using (var stream = new FileStream(oauthClientIdPath, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    return GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.Load(stream).Secrets,
                            scopes,
                            "user",
                            CancellationToken.None,
                            new FileDataStore(tokenFullPath, true))
                        .Result;
                }
                finally
                {
                    Console.WriteLine("Token saved to: " + tokenFullPath);
                }
            }
        }
    }
}
