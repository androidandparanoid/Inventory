using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Core.Models
{
    public partial class HardwareInventory
    {
        public string HDId { get; set; }
        [Required, StringLength(24)]
        public string HostName { get; set; }
        public HDType ChassisType { get; set; }
        [Required]
        public HDLocation Location { get; set; }
        public string OperatingSystem { get; set; }        
        public string IPAddress { get; set; }
        public string MacAddress { get; set; }
        public string DHCPServer { get; set; }
        public string DNSServer { get; set; }
        public string UserName { get; set; }
        public bool DomainMember { get; set; }
        public string Domain { get; set; }
        public string OSVersion { get; set; }
        public string SPVersion { get; set; }
        public string OSBuild { get; set; }
        public string OSInstallDate { get; set; }
        public string OSArchitecture { get; set; }
        public string LastUpdated { get; set; }
        public string LastBootUpTime { get; set; }
        public string RemoteDesktop { get; set; }
        public string TimeZone { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string RAM_MB { get; set; }
        public string Sockets { get; set; }
        public string Cores { get; set; }
        public string DiskSize_GB { get; set; }
        public string Processor { get; set; }
        public string SystemType { get; set; }      
        public string FirmwareVersion { get; set; }
        public bool Scanned { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ScanDate { get; set; }

    }
}
