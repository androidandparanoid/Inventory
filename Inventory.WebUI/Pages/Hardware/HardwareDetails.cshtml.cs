using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core.Models;
using Inventory.DataAccess.InMemory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory.WebUI
{
    public class HardwareDetailsModel : PageModel
    {
        private readonly IHardwareData hardwareData;
        private readonly ISoftwareData softwareData;
        private readonly IWarrantyData warrantyData;

        public HardwareInventory HardwareInventory { get; set; }

        public IEnumerable<SoftwareInventory> SoftwareInventory;

        public WarrantyInformation WarrantyInformation { get; set; }

        [TempData]
        public string Message { get; set; }       

        public HardwareDetailsModel(IHardwareData hardwareData, ISoftwareData softwareData, IWarrantyData warrantyData)
        {
            this.hardwareData = hardwareData;
            this.softwareData = softwareData;
            this.warrantyData = warrantyData;
        }
        public IActionResult OnGet(string hardwareId)
        {
            //HardwareInventory = new HardwareInventory();
            HardwareInventory = hardwareData.GetHardwareById(hardwareId);
            SoftwareInventory = softwareData.GetSoftwareByName(HardwareInventory.HostName);
            WarrantyInformation = warrantyData.GetWarrantyBySerial(HardwareInventory.SerialNumber);
            
           
            if (HardwareInventory == null)
            {

                TempData["Message"] = "Hardware";
                return RedirectToPage("/Shared/NotFound");
            }
            else
            {
                
                return Page();
            }

        }
    }
}