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
    public class MenuProductConfiguration : IEntityTypeConfiguration<MenuProduct>
    {
        public void Configure(EntityTypeBuilder<MenuProduct> builder)
        {
            builder.HasKey(e => e.IdMenuProducto)
                    .HasName("PK__MenuProd__2941B3DE5D51884B");

            builder.ToTable("MenuProducto");

            builder.Property(e => e.IdMenuProducto).HasColumnName("id_menu_producto");

            builder.Property(e => e.IdMenu).HasColumnName("id_menu");

            builder.Property(e => e.IdProducto).HasColumnName("id_Producto");
        }
    }
}
