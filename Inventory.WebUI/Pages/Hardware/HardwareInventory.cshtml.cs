using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core.Models;
using Inventory.DataAccess.SQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory
{
    public class HardwareInventoryModel : PageModel
    {
        private readonly IHardwareData hardwareData;
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }
        public IEnumerable<TblInventory> HardwareInventories;

        public HardwareInventoryModel(IHardwareData hardwareData)
        {
            this.hardwareData = hardwareData;
        }
        public void OnGet()
        {
            HardwareInventories = hardwareData.GetHardwareByName(SearchTerm);
            //HardwareInventories = hardwareData.GetAll();
        }
    }
}