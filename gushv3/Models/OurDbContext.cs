using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gushv3.Models
{
    public class OurDbContext :DbContext
    {
        public DbSet<Users> user { get; set; }
    }
}