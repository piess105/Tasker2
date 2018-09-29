using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Factories;
using Tasker.BL.Managers;
using Tasker.BL.Providers;
using Tasker.BL.Proxies;
using Tasker.BL.Pub.Managers;
using Tasker.BL.Savers;

namespace Tasker.BL.Infrastructure
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(

                AddAsTransient<SheetDataProviderProxy>(),
                AddAsTransient<SheetDataSaverProxy>(),
                AddAsTransient<SheetDataSaver>(),
                AddAsTransient<SheetDataProvider>(),
                AddAsTransient<SheetHeaderModelFactory>(),
                AddAsTransient<SheetCellModelFactory>(),
                AddAsTransient<SheetsServiceFactory>(),
                AddAsTransient<SheetRowModelFactory>(),
                AddAsTransient<IMonitoringManagerBL, MonitoringManagerBL>()

                );
        }

        private ComponentRegistration<TService> AddAsTransient<TService, TImplementation>()
            where TService : class
            where TImplementation : TService
        {
            var res = Component
                .For<TService>()
                .ImplementedBy<TImplementation>()
                .LifeStyle.Transient;

            return res;
        }

        private ComponentRegistration<TService> AddAsTransient<TService>()
          where TService : class
        {
            var res = Component
                .For<TService>()
                .LifeStyle.Transient;

            return res;
        }
    }
}