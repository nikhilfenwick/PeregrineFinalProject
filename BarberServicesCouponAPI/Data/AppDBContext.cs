using BarberServicesCouponAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;   

namespace BarberServicesCouponAPI.Data
{
    public class AppDBContext : DbContext
    { 
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            //empty for now.
        }

        public DbSet<BarberCoupon> barberCoupons{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            // Model Builder Late
        }
    }



}