using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class VInventoryData
    {
        public string ComputerName { get; set; }
        public string Ipv4address { get; set; }
        public DateTime? LastLogonDate { get; set; }
        public int? LogonCount { get; set; }
        public DateTime? LastLogonTimeStamp { get; set; }
        public string UserName { get; set; }
        public string SerialNumber { get; set; }
        public string Processor { get; set; }
        public int? Cores { get; set; }
        public int? Sockets { get; set; }
        public int? RamMb { get; set; }
        public string Dhcpserver { get; set; }
        public string Dnsserver { get; set; }
        public string DiskSizeGb { get; set; }
        public string Domain { get; set; }
        public string DomainMember { get; set; }
        public DateTime? LastBootUpTime { get; set; }
        public string Macaddress { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public string Osarchitecture { get; set; }
        public int? Osbuild { get; set; }
        public string Osversion { get; set; }
        public string SystemType { get; set; }
        public int? Spversion { get; set; }
    }
}
