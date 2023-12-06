using CodeCina.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeCina.Infraestructure.Persistence.Configurations
{
    public class MeasureConfiguration: IEntityTypeConfiguration<Measure>
    {
        public void Configure(EntityTypeBuilder<Measure> builder)
        {
            builder.HasKey(e => e.IdMeasure)
                        .HasName("PK__Measure__EC2028C251CCFCB6");

            builder.ToTable("Measure");

            builder.Property(e => e.IdMeasure).HasColumnName("id_measure");

            builder.Property(e => e.Abbreviation)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("abbreviation");

            builder.Property(e => e.DescriptionMeasure)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("descriptionMeasure");

            builder.Property(e => e.MeasureState).HasColumnName("measureState");
        }
    }
}
