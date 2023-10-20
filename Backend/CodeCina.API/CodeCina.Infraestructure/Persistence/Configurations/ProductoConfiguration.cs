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

    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(e => e.IdProducto)
                .HasName("PK__Producto__DB05CEDB5A4BAED6");

            builder.ToTable("Producto");

            builder.Property(e => e.IdProducto).HasColumnName("id_Producto");
                
            builder.Property(e => e.Cantidad).HasColumnName("cantidad");

            builder.Property(e => e.IdMedida).HasColumnName("id_medida");

            builder.Property(e => e.IdTipoProducto).HasColumnName("id_tipoProducto");

            builder.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre");
        }
    }
}
