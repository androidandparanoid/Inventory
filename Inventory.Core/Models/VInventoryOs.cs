using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class VInventoryOs
    {
        public string ComputerName { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }
        public string Osversion { get; set; }
        public int? Osbuild { get; set; }
        public string OperatingSystem { get; set; }
        public int? Spversion { get; set; }
    }
}
