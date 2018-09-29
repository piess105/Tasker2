using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Microsoft.AspNet.SignalR;
using Owin;

namespace Tasker.Service
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = StaticWindsorContainer.Container;

            var logger = container.Resolve<ILogger>();
            var hub = new MyHub(container.Kernel, logger);

            GlobalHost.DependencyResolver.Register(
                typeof(MyHub),
                () => hub
            );

            app.MapSignalR();
        }
    }
}
