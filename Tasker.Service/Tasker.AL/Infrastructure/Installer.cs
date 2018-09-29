using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.AL.Managers;
using Tasker.AL.Pub.Managers;

namespace Tasker.AL.Infrastructure
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(

                    Component
                .For<IMonitoringManagerAL>()
                .ImplementedBy<MonitoringManagerAL>()
                .LifeStyle.Transient


                );
        }
    }
}
