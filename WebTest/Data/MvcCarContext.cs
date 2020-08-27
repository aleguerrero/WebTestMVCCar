using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Data
{
    public class MvcCarContext : DbContext
    {
        public MvcCarContext(DbContextOptions<MvcCarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
    }
}
