using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core;
using Inventory.DataAccess.InMemory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory
{
    public class SoftwareInventoryModel : PageModel
    {
        private readonly ISoftwareData softwareData;

        public IEnumerable<SoftwareInventory> SoftwareInventories;

        public SoftwareInventoryModel(ISoftwareData softwareData)
        {
            this.softwareData = softwareData;
        }
        public void OnGet()
        {
            SoftwareInventories = softwareData.GetAll();
        }
    }
}