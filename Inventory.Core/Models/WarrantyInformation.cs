using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Core.Models
{
    public partial class WarrantyInformation
    {
        public string WarrantyID { get; set; }
        [Key]
        public string AssetTag { get; set; }
        public string Model { get; set; }
        public string ModelFamily { get; set; }
        public string ProductId { get; set; }
        public DateTime WarrantyStartDate { get; set; }
        public DateTime WarrantyEndDate { get; set; }
        public bool Checked { get; set; }
        public DateTime ScanDate { get; set; }
        public int WarrantyDaysLeft { get; set; }
        public int WarrantyMonthsLeft { get; set; }
        public int WarrantyYearsLeft { get; set; }
        public WarrantyStatus Status { get; set; }
        public string Memory { get; set; }
        public string Storage { get; set; }
    }
}
