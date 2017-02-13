using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web.Http;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace OwinWebApp
{
    public class GDriveController : ApiController
    {
        private const string ApplicationName = "Locally hosted app";

        public UserCredential Credential { get; }

        public GDriveController()
        {
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                var credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        new[] {DriveService.Scope.DriveReadonly},
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true))
                    .Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
        }

        public IEnumerable<string> Get()
        {
            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = Credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            var listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            return listRequest.Execute().Files.Select(file => file.Name);
        }
    }
}
