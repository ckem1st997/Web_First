using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_First.Models;

namespace Web_First.Data
{
    public class Web_FirstContext : DbContext
    {
        public Web_FirstContext (DbContextOptions<Web_FirstContext> options)
            : base(options)
        {
        }

        public DbSet<Web_First.Models.San_Pham> San_Pham { get; set; }

        public DbSet<Web_First.Models.quan> quan { get; set; }
    }
}
