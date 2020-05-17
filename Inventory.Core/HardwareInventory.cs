using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Core
{
    public partial class HardwareInventory
    {
        public string HDId { get; set; }
        public string HostName { get; set; }
        public string Location { get; set; }
        public HDType Type { get; set; }
        public string OperatingSystem { get; set; }        

    }
}
