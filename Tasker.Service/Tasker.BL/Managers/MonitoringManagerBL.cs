using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Extensions;
using Tasker.BL.Factories;
using Tasker.BL.Providers;
using Tasker.BL.Proxies;
using Tasker.BL.Pub.Managers;
using Tasker.BL.Savers;

namespace Tasker.BL.Managers
{
    public class MonitoringManagerBL : IMonitoringManagerBL
    {
        public MonitoringManagerBL(
            SheetDataSaverProxy sheetDataSaverProxy,
            SheetDataProviderProxy sheetDataProviderProxy)
        {
            SheetDataSaverProxy = sheetDataSaverProxy;
            SheetDataProviderProxy = sheetDataProviderProxy;
        }

        private SheetDataSaverProxy SheetDataSaverProxy { get; }
        private SheetDataProviderProxy SheetDataProviderProxy { get; }

        public void Begin()
        {
            var models = SheetDataProviderProxy.GetAll();

            var model = models[2].Cells[0];
            model.Content = "Wozek";

            SheetDataSaverProxy.Save(model);
        }
    }
}
