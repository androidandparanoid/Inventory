using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core.Models;
using Inventory.DataAccess.SQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory.WebUI
{
    public class HardwareDetailsModel : PageModel
    {
        private readonly IHardwareData hardwareData;
        private readonly ISoftwareData softwareData;
        private readonly IDellWarrantyData dellWarrantyData;
        private readonly IHPWarrantyData hpWarrantyData;

        public TblInventory HardwareInventory { get; set; }

        public IEnumerable<TblSoftware> SoftwareInventory;
        public TblDellWarranty DellWarrantyInformation { get; set; }
        public TblHpwarranty HPWarrantyInformation { get; set; }
        public WarrantyInformation WarrantyInformation { get; set; }

        [TempData]
        public string Message { get; set; }       

        public HardwareDetailsModel(IHardwareData hardwareData, ISoftwareData softwareData, IDellWarrantyData dellWarrantyData, IHPWarrantyData hpWarrantyData /*, IWarrantyData warrantyData*/)
        {
            this.hardwareData = hardwareData;
            this.softwareData = softwareData;
            this.dellWarrantyData = dellWarrantyData;
            this.hpWarrantyData = hpWarrantyData;
        }
        public IActionResult OnGet(int hardwareId)
        {
            if (ModelState.IsValid)
            {
                HardwareInventory = hardwareData.GetHardwareById(hardwareId);
                SoftwareInventory = softwareData.GetSoftwareByName(HardwareInventory.ComputerName);
                DellWarrantyInformation = dellWarrantyData.GetWarrantyBySerial(HardwareInventory.SerialNumber);
                HPWarrantyInformation = hpWarrantyData.GetWarrantyBySerial(HardwareInventory.SerialNumber);
            }
            
            

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