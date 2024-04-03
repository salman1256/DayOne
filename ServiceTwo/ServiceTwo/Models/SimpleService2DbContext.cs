using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ServiceTwo.Models
{
    public partial class SimpleService2DbContext : DbContext
    {
        public SimpleService2DbContext()
        {
        }

        public SimpleService2DbContext(DbContextOptions<SimpleService2DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=SALMANMCT\\SQLEXPRESS;database=SimpleService2Db;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Player__C577554073F4DD58");

                entity.ToTable("Player");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("PId");

                entity.Property(e => e.Pavg).HasColumnName("PAvg");

                entity.Property(e => e.Pname).HasMaxLength(50);

                entity.Property(e => e.Ptype)
                    .HasMaxLength(50)
                    .HasColumnName("PType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
