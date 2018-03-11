using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CleanUp.Pages
{
    public class IndexModel : PageModel
    {
        public DateTime Time { get; set; }
        public string DB { get; set; }

        public IConfiguration Configuration { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void OnGet()
        {
            Time = DateTime.Now;
            DB = Configuration["DbConnection"];
        }
    }
}