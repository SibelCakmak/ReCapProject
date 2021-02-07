using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework

    // Context : Db tabloları ile bağlandı oluşturmak
{
    public class CarContext:DbContext
    {

        // proje ile hangi veri tabnı ile eşleştireceğimizi belirteceğimiz yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentCarDb;Trusted_Connection=true");
        }

        // Hangi colona ne karşılık gelecek
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
 
    }
}
