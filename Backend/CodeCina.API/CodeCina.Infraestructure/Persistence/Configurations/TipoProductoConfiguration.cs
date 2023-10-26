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
    
    public class TipoProductoConfiguration : IEntityTypeConfiguration<TypeProduct>
    {
        public void Configure(EntityTypeBuilder<TypeProduct> builder)
        {
            builder.HasKey(e => e.IdTipoProducto)
                        .HasName("PK__TipoProd__E2BCFC711659C103");

            builder.ToTable("TipoProducto");

            builder.Property(e => e.IdTipoProducto).HasColumnName("id_tipoProducto");

            builder.Property(e => e.Nombre)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("nombre");
        }
    }
}
