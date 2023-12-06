using CodeCina.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Infraestructure.Persistence.Configurations
{
    public class DishProductConfiguration : IEntityTypeConfiguration<DishProduct>
    {
        public void Configure(EntityTypeBuilder<DishProduct> builder)
        {
            builder.HasKey(e => e.IdDishProduct)
                    .HasName("PK__DishProd__E031F5EAE957349E");

            builder.ToTable("DishProduct");

            builder.Property(e => e.IdDishProduct).HasColumnName("id_dish_product");

            builder.Property(e => e.IdDish).HasColumnName("id_dish");

            builder.Property(e => e.IdProduct).HasColumnName("id_Product");
        }
    }
}
