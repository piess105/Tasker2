using System;
using Castle.Core.Logging;
using Castle.MicroKernel;
using Microsoft.AspNet.SignalR;

namespace Tasker.Service
{
    public class HubBase : Hub
    {
        protected IKernel Kernel { get; }
        protected ILogger Logger { get; }

        protected HubBase(
            IKernel kernel,
            ILogger logger)
        {
            Kernel = kernel;
            Logger = logger;
        }

        protected TResult WrapMgr<TMgr, TResult>(Func<TMgr, TResult> func) where TResult : class
        {
            var mgr = Kernel.Resolve<TMgr>();

            try
            {
                return func(mgr);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);

                return null;
            }
            finally
            {
                Kernel.ReleaseComponent(mgr);
            }
        }

        protected void WrapMgr<TMgr>(Action<TMgr> action)
        {
            var mgr = Kernel.Resolve<TMgr>();

            try
            {
                action(mgr);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            finally
            {
                Kernel.ReleaseComponent(mgr);
            }
        }
    }
}
