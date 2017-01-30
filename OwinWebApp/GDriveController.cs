using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Sonneville.Google;
using Sonneville.Utilities.Reflection;

namespace OwinWebApp
{
    public class GDriveController : ApiController
    {
        private readonly DriveService _driveService;

        public GDriveController()
        {
            var tokenFullPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                ExecutingAssemblyInfo.Product,
                ExecutingAssemblyInfo.Title);
            var userCredential = GoogleOAuth.CreateCredential("Google API Credentials.json", tokenFullPath, new[] {DriveService.Scope.DriveFile});
            _driveService = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = userCredential,
                ApplicationName = ExecutingAssemblyInfo.Title,
            });
        }

        public IEnumerable<string> Get()
        {
            // Define parameters of request.
            var listRequest = _driveService.Files.List();
            listRequest.PageSize = 1000;
            listRequest.Fields = "nextPageToken, files(id, name)";
            FileList fileList;

            // List files.
            do
            {
                fileList = listRequest.Execute();
                foreach (var file in fileList.Files)
                {
                    yield return file.Name;
                }
                listRequest.PageToken = fileList.NextPageToken;
            } while (fileList.NextPageToken != null);
        }
    }
}
