using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class VAssetWarranty
    {
        public string AssetTag { get; set; }
        public string Model { get; set; }
        public string ModelFamily { get; set; }
        public string ProductId { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public bool? Checked { get; set; }
        public DateTime? ValidationDate { get; set; }
        public int? WarrantyDaysLeft { get; set; }
        public int? WarrantyMonthsLeft { get; set; }
        public int? WarrantyYearsLeft { get; set; }
        public string WarrantyStatus { get; set; }
        public string Storage { get; set; }
        public string Memory { get; set; }
    }
}
