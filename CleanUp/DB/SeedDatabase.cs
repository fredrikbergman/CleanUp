using CleanUp.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanUp.DB
{
    public static class SeedDatabase
    {
        public static void InitializeDB(CleanUpContext cleanUpContext, ILogger<Program> logger)
        {
            cleanUpContext.Database.EnsureCreated();

            if (cleanUpContext.Activities.Any())
            {
                logger.LogInformation("Database already seeded");
                return;
            }

            var activities = new List<Activity>()
            {
                new Activity { Name = "Dammsug ett sovrum", Category = Category.Barn, Description = "Dammsug ditt eller någon annans sovrum." },
                new Activity { Name = "Putsa badrumsspeglar", Category = Category.Ungdom, Description = "Putsa alla era badrumsspeglar." },
                new Activity { Name = "Toalettrengöring", Category = Category.Vuxen, Description = "Otur!" },
                new Activity { Name = "Plocka upp leksaker", Category = Category.Barn, Description = "Lägg alla leksaker på sin plats." },
            };

            foreach (var item in activities)
            {
                cleanUpContext.Activities.Add(item);
                logger.LogInformation(item.Name);
            }

            cleanUpContext.SaveChanges();
            logger.LogInformation("Database seeded");
        }
    }
}
