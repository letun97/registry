using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CustomIdentityApp.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }//доктор
        
       public DbSet<Reception> Receptions { get; set; }//заявки

       

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
