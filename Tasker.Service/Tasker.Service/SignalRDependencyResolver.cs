using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Microsoft.AspNet.SignalR;

namespace Tasker.Service
{
    public class SignalRDependencyResolver : DefaultDependencyResolver
    {
        private readonly IWindsorContainer _container;

        public SignalRDependencyResolver(IWindsorContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        public override object GetService(Type serviceType)
        {
            return _container.Kernel.HasComponent(serviceType)
                ? _container.Resolve(serviceType)
                : base.GetService(serviceType);
        }

        public override IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.Kernel.HasComponent(serviceType)
                ? _container.ResolveAll(serviceType).Cast<object>()
                : base.GetServices(serviceType);
        }
    }
}
