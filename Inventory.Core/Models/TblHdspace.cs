using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class TblHdspace
    {
        public int Id { get; set; }
        public string ComputerName { get; set; }
        public string Drive { get; set; }
        public string Caption { get; set; }
        public bool? BootVolume { get; set; }
        public long? RawSize { get; set; }
        public double? Size { get; set; }
        public double? FreeSpace { get; set; }
        public string SerialNumber { get; set; }
        public string FileSystem { get; set; }
        public DateTime? Qdate { get; set; }
    }
}
