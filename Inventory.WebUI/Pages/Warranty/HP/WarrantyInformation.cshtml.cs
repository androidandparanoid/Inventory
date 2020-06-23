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
    public class HPWarrantyInformationModel : PageModel
    {
        private readonly IHPWarrantyData hpWarrantyData;

        public IEnumerable<TblHpwarranty> HPWarrantyInformation;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public HPWarrantyInformationModel(IHPWarrantyData hpWarrantyData)
        {
            this.hpWarrantyData = hpWarrantyData;
        }
        public void OnGet()
        {
            HPWarrantyInformation = hpWarrantyData.GetWarrantyByAsset(SearchTerm);
            //WarrantyInformation = warrantyData.GetAll();
        }
    }
}