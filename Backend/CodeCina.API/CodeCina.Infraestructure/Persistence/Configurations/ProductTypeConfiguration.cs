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
    
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(e => e.IdTypeProduct)
                    .HasName("PK__ProductT__A44A8A4B411BF664");

            builder.ToTable("ProductType");

            builder.Property(e => e.IdTypeProduct).HasColumnName("id_typeProduct");

            builder.Property(e => e.NameProductType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nameProductType");

            builder.Property(e => e.ProductTypeState).HasColumnName("productTypeState");
        }
    }
}
