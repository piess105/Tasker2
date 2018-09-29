using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Factories;
using Tasker.BL.Pub.Providers;

namespace Tasker.BL.Providers
{
    public class SheetDataProvider
    {
        public SheetDataProvider(
            IConfigurationProvider configurationProvider,
            SheetsServiceFactory sheetsServiceFactory)
        {
            ConfigurationProvider = configurationProvider;
            SheetsServiceFactory = sheetsServiceFactory;
        }

        private IConfigurationProvider ConfigurationProvider { get; }
        private SheetsServiceFactory SheetsServiceFactory { get; }

        public IList<IList<string>> GetData()
        {
            var values = GetValues();

            var upTo = values[0].Count; //HeaderCount

            values = FillWithEmptyValues(values, upTo);

            var res = CastValues(values);

            return res;
        }

        private IList<IList<string>> CastValues(IList<IList<Object>> values)
        {
            var res = new List<IList<string>>();

            foreach (var value in values)
            {
                var o = value.Cast<string>().ToList();

                res.Add(o);
            }

            return res;
        }

        private IList<IList<Object>> FillWithEmptyValues(IList<IList<Object>> values, int upTo)
        {
            for(var i = 0; i < values.Count; i++)
            {
                var left = upTo - values[i].Count;

                for(var j = 0; j < left; j++)
                {
                    values[i].Add("");
                }
            }

            return values;
        }

        private IList<IList<Object>> GetValues()
        {
            var service = SheetsServiceFactory.Create();

            var range = "A1:Z";
            var request =
                   service.Spreadsheets.Values.Get(ConfigurationProvider.SpreedsheetId, range);

            var response = request.Execute();
            IList<IList<Object>> values = response.Values;

            return values;
        }
    }
}
