using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TEST_APP.Pages
{
    public class IndexModel : PageModel
    {
        public string[] Food 
        {
            get;
            set;
        }
        public string getUrl
        {
            get;
            private set;
        }
        public void OnGet()
        {
            Food = new string[]
            {
                "Tacos", "Pizza", "Pasta", "Sallad", "Sushi"
            };
            getUrl = Request.Query["produkt"];
        }
        
    }
}
