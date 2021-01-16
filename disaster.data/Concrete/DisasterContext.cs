using System;
using disaster.entity;
using Microsoft.EntityFrameworkCore;

namespace disaster.data.Concrete
{
    public class DisasterContext:DbContext
    {
        private string _connectionString = @"server=localhost;port=3306;user=root;password=Mysql-1234;database=DisasterDb";
        public DbSet<Disaster> Disasters { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString,x=>x.UseNetTopologySuite());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disaster>().HasMany(i=>i.Cities);
            modelBuilder.Entity<Disaster>().HasMany(i=>i.Towns);

            modelBuilder.Entity<City>().HasMany(i=>i.Towns).WithOne(i=>i.City).IsRequired();




            
        }
        
     
    }
}