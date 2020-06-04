using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inventory.WebUI
{
    public class NotFoundModel : PageModel
    {       
        public string Message { get; set; }        
        public string ReturnUrl { get; set; }                
        public IActionResult OnGet()
        {
            if(TempData["Message"] != null){
                
                Message = TempData["Message"].ToString();
                ReturnUrl = "~/Hardware/HardwareInventory";
                return Page();
            }
            else
            {
                return RedirectToPage("/index");
            }
            
            
            
        }
    }
}