using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Site.Data.Model;

namespace Site.Data.DataContext
{
    public class SiteContext : DbContext
    {
      
        public DbSet<Kullanici> Kullanici { get; set; }

        public DbSet<Rol> Rol { get; set; }
    }
}
