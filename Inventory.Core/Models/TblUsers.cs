using System;
using System.Collections.Generic;

namespace Inventory.Core.Models
{
    public partial class TblUsers
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public double? Geid { get; set; }
        public string Email { get; set; }
        public bool? Enabled { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Division { get; set; }
        public bool? Adstatus { get; set; }
        public double? ManagerLevel { get; set; }
        public DateTime? LastLogonDate { get; set; }
        public int? LogonCount { get; set; }
        public DateTime? LastLogonTimeStamp { get; set; }
    }
}
