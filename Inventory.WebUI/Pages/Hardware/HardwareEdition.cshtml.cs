using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core.Models;
using Inventory.DataAccess.SQL;
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
        public TblInventory HardwareInventory { get; set; }

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
                HardwareInventory = hardwareData.GetHardwareById(Convert.ToInt32(hardwareId));
            }
            else
            {
                HardwareInventory = new TblInventory();
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

            if (HardwareInventory.Id != null)
            {
                hardwareData.Update(HardwareInventory);
                TempData["Message"] = $"Asset: {HardwareInventory.ComputerName} Updated!";
            }
            else
            {
                hardwareData.Add(HardwareInventory);
                TempData["Message"] = $"Asset: {HardwareInventory.ComputerName} Added!";
            }

            hardwareData.Commit();

            return RedirectToPage("./HardwareEdition/", new { hardwareId = HardwareInventory.Id });
        }
    }
}