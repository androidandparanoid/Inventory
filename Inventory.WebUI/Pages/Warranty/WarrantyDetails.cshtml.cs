using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Core.Models;
using Inventory.DataAccess.InMemory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory.WebUI.Pages.Warranty
{
    public class WarrantyDetailsModel : PageModel
    {
        private readonly IWarrantyData warrantyData;

        public IEnumerable<WarrantyInformation> WarrantyInformation;

        [TempData]
        public string Message { get; set; }

        public string SearchQuery { get; set; }

        public WarrantyDetailsModel(IWarrantyData warrantyData)
        {
            this.warrantyData = warrantyData;
        }
        public IActionResult OnGet(string? searchQuery)
        {
            WarrantyInformation = warrantyData.GetWarrantyByAsset(searchQuery);

            if (WarrantyInformation == null)
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