using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class VAsset2User
    {
        public string ComputerName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public double? Geid { get; set; }
        public string IpAddress { get; set; }
        public string OperatingSystem { get; set; }
        public string Description { get; set; }
    }
}
