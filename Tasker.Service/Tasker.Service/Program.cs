using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor.Installer;

namespace Tasker.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = StaticWindsorContainer.Container;

            container.Install(
                FromAssembly.This(),
                FromAssembly.Named("Tasker.AL"),
                FromAssembly.Named("Tasker.BL"),
                FromAssembly.Named("Tasker.Data")
                );

            var service = container.Resolve<MyService>();

            if (!Environment.UserInteractive)
            {
                var servicesToRun = new ServiceBase[]
                {
                    service
                };
                ServiceBase.Run(servicesToRun);
            }
            else
            {
                service.Start();

                Console.ReadLine();
            }
        }
    }
}
