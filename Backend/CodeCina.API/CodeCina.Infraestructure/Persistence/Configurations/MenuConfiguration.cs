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
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(e => e.IdMenu)
    .HasName("PK__Menu__68A1D9DB38A93BEE");

            builder.ToTable("Menu");

            builder.Property(e => e.IdMenu).HasColumnName("id_menu");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            builder.Property(e => e.Nota)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nota");
        }
    }
}

