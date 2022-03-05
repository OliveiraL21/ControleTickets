using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapeamento
{
    public class ResultMap : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder.ToTable("Result");
            builder.HasKey(r => r.ResultId);
            builder.Property(r => r.TotalHoras).IsRequired();
            builder.Property(r => r.TotalHorasDiaria).IsRequired();

            builder.HasMany(t => t.Tickets).WithOne(r => r.Result).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
