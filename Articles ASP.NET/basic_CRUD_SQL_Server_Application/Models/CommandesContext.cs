using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace basic_CRUD_SQL_Server_Application.Models
{
    public partial class CommandesContext : DbContext
    {
        public CommandesContext()
        {
        }

        public CommandesContext(DbContextOptions<CommandesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartLine> CartLines { get; set; }
        public virtual DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("carts");

                entity.Property(e => e.CartId)
                    .ValueGeneratedNever()
                    .HasColumnName("cartId");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(10)
                    .HasColumnName("clientName")
                    .IsFixedLength(true);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");
            });

            modelBuilder.Entity<CartLine>(entity =>
            {
                entity.ToTable("cartLines");

                entity.Property(e => e.CartLineId)
                    .ValueGeneratedNever()
                    .HasColumnName("cartLineId");

                entity.Property(e => e.CartHeader).HasColumnName("cartHeader");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.CartHeaderNavigation)
                    .WithMany(p => p.CartLines)
                    .HasForeignKey(d => d.CartHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cartLines_carts");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartLines)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cartLines_products");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productId");

                entity.Property(e => e.ProductImage)
                    .HasColumnType("image")
                    .HasColumnName("productImage");

                entity.Property(e => e.ProductLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productLabel");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("unitPrice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
