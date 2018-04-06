using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanUp.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public Category Category { get; set; }

    }
}
