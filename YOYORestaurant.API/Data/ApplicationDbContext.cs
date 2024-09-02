using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YOYORestaurant.API.Models;

namespace YOYORestaurant.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection"){}

        public DbSet<Customer> Customers { get; set; }
    }
}