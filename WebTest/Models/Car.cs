using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
