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
    public class WarrantyInformationModel : PageModel
    {
        private readonly IWarrantyData warrantyData;
        public IEnumerable<WarrantyInformation> WarrantyInformation;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public WarrantyInformationModel(IWarrantyData warrantyData)
        {
            this.warrantyData = warrantyData;
        }
        public void OnGet()
        {
            WarrantyInformation = warrantyData.GetWarrantyByAsset(SearchTerm);
            //WarrantyInformation = warrantyData.GetAll();
        }
    }
}