using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Factories;
using Tasker.BL.Providers;
using Tasker.Models.Pub;

namespace Tasker.BL.Proxies
{
    public class SheetDataProviderProxy
    {
        public SheetDataProviderProxy(
            SheetRowModelFactory sheetModelFactory,
            SheetDataProvider sheetDataProvider)
        {
            SheetModelFactory = sheetModelFactory;
            SheetDataProvider = sheetDataProvider;
        }

        private SheetRowModelFactory SheetModelFactory { get; }
        private SheetDataProvider SheetDataProvider { get; }

        public IList<SheetRowModel> GetAll()
        {
            var datas = SheetDataProvider.GetData();

            var models = SheetModelFactory.Create(datas);

            return models;
        }
    }
}
