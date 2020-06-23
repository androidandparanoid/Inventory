using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class TblSoftwareScan
    {
        public int Id { get; set; }
        public string ComputerName { get; set; }
        public bool? Scanned { get; set; }
        public DateTime? Qdate { get; set; }
    }
}
