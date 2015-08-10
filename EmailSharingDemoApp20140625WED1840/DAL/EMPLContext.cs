using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using EmailSharingDemoApp20140625WED1840.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmailSharingDemoApp20140625WED1840.DAL
{
    public class EMPLContext : DbContext
    {
        public EMPLContext():base("EMPLContext")
        {
        }

        public DbSet<EMPL> EMPL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}