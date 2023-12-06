using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCina.Domain.Entities;

namespace CodeCina.Infraestructure.Persistence.Configurations
{

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.IdProduct)
                    .HasName("PK__Product__A828825D30977EAA");

            builder.ToTable("Product");

            builder.Property(e => e.IdProduct).HasColumnName("id_Product");

            builder.Property(e => e.IdMeasure).HasColumnName("id_measure");

            builder.Property(e => e.IdTypeProduct).HasColumnName("id_typeProduct");

            builder.Property(e => e.ProductName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("productName");

            builder.Property(e => e.ProductState).HasColumnName("productState");

            builder.Property(e => e.Quantity).HasColumnName("quantity");
        }
    }
}
