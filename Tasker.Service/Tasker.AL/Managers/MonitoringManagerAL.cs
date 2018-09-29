using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.AL.Pub.Managers;
using Tasker.BL.Pub.Managers;

namespace Tasker.AL.Managers
{
    public class MonitoringManagerAL : IMonitoringManagerAL
    {
        public MonitoringManagerAL(IMonitoringManagerBL managerBL)
        {
            ManagerBL = managerBL;
        }

        private IMonitoringManagerBL ManagerBL { get; }

        public void Begin()
        {
            ManagerBL.Begin();
        }
    }
}
