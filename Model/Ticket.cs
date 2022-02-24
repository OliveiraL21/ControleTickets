using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Codigo { get; set; }
        public TimeSpan? HorarioDeInicio { get; set; }
        public TimeSpan? HoririoFinal { get; set; }
        public DateTime Date { get; set; }
        public string Descricao { get; set; }
        public TimeSpan? TotalHorasGasto { get; set; }

    }
}
