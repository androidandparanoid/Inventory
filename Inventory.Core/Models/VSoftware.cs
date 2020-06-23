using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class VSoftware
    {
        public string ComputerName { get; set; }
        public string Program { get; set; }
        public string Version { get; set; }
        public string Publisher { get; set; }
        public DateTime? InstallDate { get; set; }
        public string InstallSource { get; set; }
        public string InstallLocation { get; set; }
        public string RegistryKey { get; set; }
        public DateTime? Qdate { get; set; }
    }
}
