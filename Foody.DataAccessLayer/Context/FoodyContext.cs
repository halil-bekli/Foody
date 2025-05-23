﻿using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Context {
    public class FoodyContext : DbContext {
        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=Halil-PC\\SQLEXPRESS;Initial Catalog=FoodyDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
