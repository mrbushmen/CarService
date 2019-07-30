namespace CarServiceDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Car1)
                .HasForeignKey(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.Owner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Service1)
                .HasForeignKey(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Worker1)
                .HasForeignKey(e => e.Worker)
                .WillCascadeOnDelete(false);
        }
    }
}
