using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace simplest_new.Models
{
    public class usermangerContext:DbContext
    {
        public DbSet<user> users { get; set; }
    }
}