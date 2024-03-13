using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeTourOperator.Infrastructure.Data.Models;

namespace PrimeTourOperator.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<HotelVacation>().HasKey(hv => new { hv.VacationId, hv.HodelId });
            builder.Entity<HotelVacation>()
                .HasOne(hv => hv.Hotel)
                .WithMany(hv => hv.HotelVacations)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<VacationCustomer>().HasKey(vc => new { vc.VacationId, vc.UserId });
            builder.Entity<VacationCustomer>()
                .HasOne(vc => vc.Vacation)
                .WithMany(vc => vc.VacationCustomers)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Vacation>().Property(v => v.Price).HasColumnType("decimal(18,2)");
            builder.Entity<Room>().Property(r => r.Price).HasColumnType("decimal(18,2)");
            base.OnModelCreating(builder);
        }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelVacation> HotelVacations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<VacationCategory> VacationCategories { get; set; }
        public DbSet<VacationCustomer> VacationCustomers { get; set; }

    }
}
