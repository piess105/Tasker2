using Castle.Core.Logging;
using Castle.MicroKernel;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Data.Providers
{
    public abstract class ProviderBase
    {
        protected ILogger Logger { get; }
        private IKernel Kernel { get; }

        public ProviderBase(
            ILogger logger,
            IKernel kernel)
        {
            Logger = logger;
            Kernel = kernel;
        }

        protected TResult WrapSession<TResult>(Func<ISession, TResult> func)
        {
            ISession session = null;

            try
            {
                session = Kernel.Resolve<ISession>();

                var res = func(session);

                return res;
            }
            catch(Exception ex)
            {
                Logger.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                Kernel.ReleaseComponent(session);
            }
        }

    }
}
