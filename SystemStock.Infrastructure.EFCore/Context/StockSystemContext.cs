using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StockSystem.Domian.Entities;

namespace SystemStock.Infrastructure.EFCore.Context;

public partial class StockSystemContext : DbContext
{
    public StockSystemContext()
    {
    }

    public StockSystemContext(DbContextOptions<StockSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProductUnit> ProductUnits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:STOCKSYSTEM");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCTS__3214EC275714629C");

            entity.ToTable("PRODUCTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.IdType).HasColumnName("ID_TYPE");
            entity.Property(e => e.IdUnit).HasColumnName("ID_UNIT");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTS__ID_TYP__3B75D760");

            entity.HasOne(d => d.IdUnitNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTS__ID_UNI__3C69FB99");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC27CD91E8B3");

            entity.ToTable("PRODUCT_TYPES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<ProductUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC275387732D");

            entity.ToTable("PRODUCT_UNITS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
