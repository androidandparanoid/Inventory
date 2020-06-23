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
    public class DellWarrantyInformationModel : PageModel
    {
        private readonly IDellWarrantyData dellWarrantyData;

        public IEnumerable<TblDellWarranty> DellWarrantyInformation;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public DellWarrantyInformationModel(IDellWarrantyData dellWarrantyData)
        {
            this.dellWarrantyData = dellWarrantyData;
        }
        public void OnGet()
        {
            DellWarrantyInformation = dellWarrantyData.GetWarrantyByAsset(SearchTerm);
            //WarrantyInformation = warrantyData.GetAll();
        }
    }
}