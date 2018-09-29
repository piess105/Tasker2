using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Pub.Providers;

namespace Tasker.Service.Providers
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public string JsonCredentialPath { get; set; }
        public string SpreedsheetId { get; set; }
    }
}
