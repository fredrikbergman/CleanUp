using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CleanUp.Pages
{
    public class IndexModel : PageModel
    {
        public DateTime Time { get; set; }
        public string DB { get; set; }

        private IConfiguration Configuration { get; set; }
        private ILogger<IndexModel> Logger { get; set; }

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
        {
            Configuration = configuration;
            Logger = logger;
        }

        public void OnGet()
        {
            Time = DateTime.Now;
            DB = Configuration["DbConnection"];
            Logger.LogInformation("Loggar info");
            Logger.LogWarning("Loggar varning");
            Logger.LogError("Loggar error");
        }
    }
}