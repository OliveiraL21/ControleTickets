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
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => t.TicketID);
            builder.Property(t => t.Codigo).IsRequired();
            builder.Property(t => t.HorarioDeInicio).IsRequired();
            builder.Property(t => t.HorarioFinal).IsRequired();
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.TotalHorasGasto);

            builder.ToTable("Ticket");
        }
    }
}
