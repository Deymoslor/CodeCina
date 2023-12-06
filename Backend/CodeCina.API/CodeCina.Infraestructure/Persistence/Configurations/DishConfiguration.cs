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
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.HasKey(e => e.IdDish)
                    .HasName("PK__Dish__972B43E953FC4C5F");

            builder.ToTable("Dish");

            builder.Property(e => e.IdDish).HasColumnName("id_dish");

            builder.Property(e => e.DishDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dishDescription");

            builder.Property(e => e.DishImageUrl)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("dishImageUrl");

            builder.Property(e => e.DishName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dishName");

            builder.Property(e => e.DishNote)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("dishNote");

            builder.Property(e => e.DishState).HasColumnName("dishState");

            builder.Property(e => e.Price).HasColumnName("price");
        }
    }
}

