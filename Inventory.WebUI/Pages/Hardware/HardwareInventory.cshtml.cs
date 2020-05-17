using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core;
using Inventory.DataAccess.InMemory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory
{
    public class HardwareInventoryModel : PageModel
    {
        private readonly IHardwareData hardwareData;

        public IEnumerable<HardwareInventory> HardwareInventories;

        public HardwareInventoryModel(IHardwareData hardwareData)
        {
            this.hardwareData = hardwareData;
        }
        public void OnGet()
        {
            HardwareInventories = hardwareData.GetAll();
        }
    }
}