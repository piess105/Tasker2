using System;
using Castle.Core.Logging;
using Castle.MicroKernel;

namespace Tasker.Service
{
    public class MyHub : HubBase
    {
        public MyHub(IKernel kernel, ILogger logger) : base(kernel, logger)
        {

        }
    }
}
