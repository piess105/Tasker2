using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace Tasker.Service
{
    public class StaticWindsorContainer
    {
        private static IWindsorContainer _container;
        public static IWindsorContainer Container => _container ?? (_container = new WindsorContainer());
    }
}
