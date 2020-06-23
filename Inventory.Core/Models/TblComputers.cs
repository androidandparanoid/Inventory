using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class TblComputers
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string ComputerName { get; set; }
        public string UserName { get; set; }
        public string Ipv4address { get; set; }
        public string Description { get; set; }
        public string Macaddress { get; set; }
        public string OperatingSystem { get; set; }
        public string Osarchitecture { get; set; }
        public string SerialNumber { get; set; }
        public bool? ConnectivityStatus { get; set; }
        public bool? Adstatus { get; set; }
        public DateTime? LastLogonDate { get; set; }
        public int? LogonCount { get; set; }
        public DateTime? LastLogonTimeStamp { get; set; }
        public DateTime? Qdate { get; set; }
    }
}
