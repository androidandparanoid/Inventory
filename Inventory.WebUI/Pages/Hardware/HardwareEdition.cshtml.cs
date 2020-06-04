using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core;
using Inventory.DataAccess.InMemory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inventory.WebUI.Pages.Hardware
{
    public class HardwareEditionModel : PageModel
    {
        private readonly IHardwareData hardwareData;       

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public HardwareInventory HardwareInventory { get; set; }

        public IEnumerable<SelectListItem> Locations { get; set; }

        public IHtmlHelper HtmlHelper { get; }

        public HardwareEditionModel(IHardwareData hardwareData, IHtmlHelper htmlHelper)
        {
            this.hardwareData = hardwareData;        
            HtmlHelper = htmlHelper;
        }
              

        public IActionResult OnGet(string? hardwareId)
        {
            Locations = HtmlHelper.GetEnumSelectList<HardwareInventory.HDLocation>();
            //HardwareInventory = hardwareData.GetHardwareById(hardwareId);

            if (!string.IsNullOrEmpty(hardwareId))
            {
                HardwareInventory = hardwareData.GetHardwareById(hardwareId);
            }
            else
            {
                HardwareInventory = new HardwareInventory();
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Locations = HtmlHelper.GetEnumSelectList<HardwareInventory.HDLocation>();
                return Page();
            }

            if (!string.IsNullOrEmpty(HardwareInventory.HDId))
            {
                hardwareData.Update(HardwareInventory);
                TempData["Message"] = $"Asset: {HardwareInventory.HostName} Updated!";
            }
            else
            {
                hardwareData.Add(HardwareInventory);
                TempData["Message"] = $"Asset: {HardwareInventory.HostName} Added!";
            }

            hardwareData.Commit();

            return RedirectToPage("./HardwareEdition/", new { hardwareId = HardwareInventory.HDId });
        }
    }
}