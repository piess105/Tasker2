using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.BL.Pub.Providers
{
    public interface IConfigurationProvider
    {
        string JsonCredentialPath { get; set; }
        string SpreedsheetId { get; set; }
    }
}
