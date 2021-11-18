using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Progress> Progresses { get; set; }


    }
}
