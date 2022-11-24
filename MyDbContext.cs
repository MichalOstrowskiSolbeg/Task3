using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Task3.DbModels
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Workplace> Workplaces { get; set; }
        public virtual DbSet<WorkplaceItem> WorkplaceItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.WhenMade).HasColumnType("datetime");

                entity.Property(e => e.WorkplaceId).HasColumnName("Workplace_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_Employee");

                entity.HasOne(d => d.Workplace)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.WorkplaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_Workplace");
            });

            modelBuilder.Entity<Workplace>(entity =>
            {
                entity.ToTable("Workplace");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkplaceItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.WorkplaceId })
                    .HasName("Workplace_Item_pk");

                entity.ToTable("Workplace_Item");

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.WorkplaceId).HasColumnName("Workplace_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.WorkplaceItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Table_4_Item");

                entity.HasOne(d => d.Workplace)
                    .WithMany(p => p.WorkplaceItems)
                    .HasForeignKey(d => d.WorkplaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Table_4_Workplace");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
