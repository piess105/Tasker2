using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adk.GoogleApis
{
    public class ApisManager
    {
        private readonly string[] scopes = new string[] { SheetsService.Scope.Spreadsheets };
        private readonly string ApplicationName = "Google Sheets API .NET Quickstart";
        

        public SheetsService GetService(byte[] key)
        {
            var stream = new MemoryStream(key);

            var credential = GoogleCredential.FromStream(stream);

            credential = credential.CreateScoped(scopes);

            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });           

            return service;
        }
    }
}
