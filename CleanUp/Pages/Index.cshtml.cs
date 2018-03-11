using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanUp.Pages
{
    public class IndexModel : PageModel
    {
        public DateTime Time { get; set; }

        public void OnGet()
        {
            Time= DateTime.Now;
        }
    }
}