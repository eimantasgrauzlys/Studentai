using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Context : DbContext
    {
       
            public DbSet<Department> Deparments { get; set; }
            public DbSet<Lecture> Lectures { get; set; }
            public DbSet<Student> Student { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
                 => options.UseSqlServer($"Server=localhost;Database=Studentu_informacine_sistema; Trusted_Connection=True");
        
    }
}
