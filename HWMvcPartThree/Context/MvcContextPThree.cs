using HWMvcPartThree.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWMvcPartThree.Context
{
    public class MvcContextPThree : DbContext
    {
        public MvcContextPThree(DbContextOptions options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FoodCategory>().HasData
                (
                   new FoodCategory { Id = 1, Name = "Meat (including poultry)" },
                   new FoodCategory { Id = 2, Name = "Fruit and vegetable" },
                   new FoodCategory { Id = 3, Name = "Starch, sugar, honey and confectionery" },
                   new FoodCategory { Id = 4, Name = "Fish and fish products" }
                );
        }
        public DbSet<Food> foods { get; set; }
        public DbSet<FoodCategory> foodCategories { get; set; }
    }
}
