using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Core.Models
{
    public class SoftwareScan
    {
        public string ScanID { get; set; }
        [Key]
        public string HostName { get; set; }
        public bool Scanned { get; set; }
        public DateTime ScanDate { get; set; }

    }
}
