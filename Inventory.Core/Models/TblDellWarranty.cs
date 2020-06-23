using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class TblDellWarranty
    {
        public int Id { get; set; }
        public string AssetTag { get; set; }
        public string Model { get; set; }
        public string ModelFamily { get; set; }
        public string ProductId { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public bool? Checked { get; set; }
        public DateTime? Qdate { get; set; }
        public int? WarrantyDaysLeft { get; set; }
        public int? WarrantyMonthsLeft { get; set; }
        public int? WarrantyYearsLeft { get; set; }
        public string WarrantyStatus { get; set; }
        public string Memory { get; set; }
        public string Storage { get; set; }
    }
}
