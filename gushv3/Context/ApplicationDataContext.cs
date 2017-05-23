using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gushv3.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace gushv3.Context
{
    public class ApplicationDataContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
 
        public System.Data.Entity.DbSet<gushv3.Models.Inventory> Inventories { get; set; }

        public System.Data.Entity.DbSet<gushv3.Models.Users> users { get; set; }

        public System.Data.Entity.DbSet<gushv3.Models.Sales> Sales { get; set; }
    }
}