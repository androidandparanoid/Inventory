using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Core.Models
{
    public class SoftwareInventory
    {
        [Key]
        public int SoftID { get; set; }
        public string HostName { get; set; }
        public string Program { get; set; }
        public string Version { get; set; }
        public string Publisher { get; set; }
        public string InstallDate { get; set; }
        public string InstallSource { get; set; }
        public string InstallLocation { get; set; }
        public string RegistryKey { get; set; }
        public DateTime ScanDate { get; set; }

    }
}
