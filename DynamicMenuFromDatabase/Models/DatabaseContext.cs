using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMenuFromDatabase.Models
{
    public class DatabaseContexts:DbContext
    {
        public DbSet<MenuMst> MenuMsts { get; set; }
    }
}