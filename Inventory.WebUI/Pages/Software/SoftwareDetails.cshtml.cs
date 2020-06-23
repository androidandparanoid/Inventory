using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core.Models;
using Inventory.DataAccess.SQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory.WebUI.Pages.Software
{
    public class SoftwareDetailsModel : PageModel
    {
        private readonly ISoftwareData softwareData;        

        public IEnumerable<TblSoftware> SoftwareInventory;

        [TempData]
        public string Message { get; set; }

        public string SearchQuery { get; set; }

        public SoftwareDetailsModel(ISoftwareData softwareData)
        {
            this.softwareData = softwareData;            
        }
        public IActionResult OnGet(string? searchQuery)
        {
            SoftwareInventory = softwareData.GetSoftwareByName(searchQuery);

            if (SoftwareInventory == null)
            {
                TempData["Message"] = "Software";
                return RedirectToPage("/Shared/NotFound");
            }
            else
            {
                SearchQuery = searchQuery;
                return Page();
            }
        }
    }
}