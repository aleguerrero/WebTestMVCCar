using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class CarMakeViewModel
    {
        public List<Car> Cars { get; set; }
        public SelectList Makes { get; set; }
        public string CarMake { get; set; }
        public string SearchString { get; set; }
    }
}
