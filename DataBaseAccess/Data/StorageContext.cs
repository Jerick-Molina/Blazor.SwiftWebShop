using DataBaseAccess.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseAccess.Data
{
   public class StorageContext : IdentityDbContext<UserModel>
    {
        public StorageContext(DbContextOptions<StorageContext> options) : base(options) { }

        public DbSet<UserModel> User { get; set; }
        public DbSet<ShoeProducts> Shoes { get; set; }
        public DbSet<ClothingProducts> Clothing { get; set; }
       
    }
}
