using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core.Models;
using Inventory.DataAccess.SQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory.WebUI.Pages.Warranty
{
    public class HPWarrantyDetailsModel : PageModel
    {
        private readonly IHPWarrantyData hpWarrantyData;

        public IEnumerable<TblHpwarranty> HPWarrantyInformation;

        [TempData]
        public string Message { get; set; }

        public string SearchQuery { get; set; }

        public HPWarrantyDetailsModel(IHPWarrantyData hpWarrantyData)
        {
            this.hpWarrantyData = hpWarrantyData;
        }
        public IActionResult OnGet(string? searchQuery)
        {
            HPWarrantyInformation = hpWarrantyData.GetWarrantyByAsset(searchQuery);

            if (HPWarrantyInformation == null)
            {
                TempData["Message"] = "Warranty";
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