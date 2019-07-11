using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CustomIdentityApp.Models
{
    
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Doctor> Doctors { get; set; }//доктор
        public DbSet<Reception> Receptions { get; set; }//заявки
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}