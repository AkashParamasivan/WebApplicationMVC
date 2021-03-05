using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class ReleaseManagementContext:DbContext
    {
      
        public ReleaseManagementContext():base("con")
        {

        }
        
        public DbSet<Remployee> Employees { get; set; }
        public DbSet<LoginDetails> EloginDetails { get; set; }
    }

}