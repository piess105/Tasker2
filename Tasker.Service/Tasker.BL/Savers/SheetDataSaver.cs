using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Factories;
using Tasker.BL.Pub.Providers;

namespace Tasker.BL.Savers
{
    public class SheetDataSaver
    {
        private IConfigurationProvider ConfigurationProvider { get; }
        private SheetsServiceFactory SheetsServiceFactory { get; }

        public SheetDataSaver(
            IConfigurationProvider configurationProvider,
            SheetsServiceFactory sheetsServiceFactory)
        {
            ConfigurationProvider = configurationProvider;
            SheetsServiceFactory = sheetsServiceFactory;
        }

        public void SaveData(string text, string range)
        {
            var service = SheetsServiceFactory.Create();

            var body = new ValueRange();

            body.Values = new List<IList<object>>();

            body.Values.Add(new List<object> { text });

            var request = service.Spreadsheets.Values.Update(body, ConfigurationProvider.SpreedsheetId, range);
            request.ValueInputOption = Google.Apis.Sheets.v4.SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;

            request.Execute();
        }
    }
}
