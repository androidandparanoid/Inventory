using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Core
{
    public class SoftwareInventory
    {
        public string SoftID { get; set; }
        public string HostName { get; set; }
        public string Program { get; set; }
        public string Version { get; set; }
        public string Publisher { get; set; }
        public string InstallDate { get; set; }

    }
}
