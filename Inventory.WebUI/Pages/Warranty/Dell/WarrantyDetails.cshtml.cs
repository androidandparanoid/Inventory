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
    public class DellWarrantyDetailsModel : PageModel
    {
        private readonly IDellWarrantyData dellWarrantyData;

        public IEnumerable<TblDellWarranty> DellWarrantyInformation;

        [TempData]
        public string Message { get; set; }

        public string SearchQuery { get; set; }

        public DellWarrantyDetailsModel(IDellWarrantyData dellWarrantyData)
        {
            this.dellWarrantyData = dellWarrantyData;
        }
        public IActionResult OnGet(string? searchQuery)
        {
            DellWarrantyInformation = dellWarrantyData.GetWarrantyByAsset(searchQuery);

            if (DellWarrantyInformation == null)
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