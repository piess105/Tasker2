using Adk.GoogleApis;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Pub.Providers;

namespace Tasker.BL.Factories
{
    public class SheetsServiceFactory
    {
        public SheetsServiceFactory(
            IConfigurationProvider configurationProvider,
            ApisManager apisManager)
        {
            ConfigurationProvider = configurationProvider;
            ApisManager = apisManager;
        }

        private IConfigurationProvider ConfigurationProvider { get; }
        private ApisManager ApisManager { get; }

        public SheetsService Create()
        {
            var key = GetBytes(ConfigurationProvider.JsonCredentialPath);

            var service = ApisManager.GetService(key);

            return service;
        }

        private byte[] GetBytes(string path)
        {
            var sr = new StreamReader(path);
            var costam = sr.ReadToEnd();
            var bytes = Encoding.UTF8.GetBytes(costam);

            return bytes;
        }
    }
}
