using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class VDiskSpace
    {
        public string ComputerName { get; set; }
        public string Ipv4address { get; set; }
        public string Drive { get; set; }
        public double? Size { get; set; }
        public double? FreeSpace { get; set; }
        public DateTime? Qdate { get; set; }
    }
}
