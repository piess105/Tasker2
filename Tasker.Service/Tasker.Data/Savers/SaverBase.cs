using Castle.Core.Logging;
using Castle.MicroKernel;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Data.Savers
{
    public abstract class SaverBase
    {
        protected ILogger Logger { get; }
        private IKernel Kernel { get; }
        
        public SaverBase(
            ILogger logger,
            IKernel kernel)
        {
            Logger = logger;
            Kernel = kernel;
        }

        protected void WrapSessionWithTransaction(Action<ISession> action)
        {
            ISession session = null;
            
            try
            {
                session = Kernel.Resolve<ISession>();

                using (var transaction = session.BeginTransaction())
                {
                    action(session);

                    transaction.Commit();
                }
            }
            catch (Exception ex)
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
