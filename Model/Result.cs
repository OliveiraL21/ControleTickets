using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Result
    {
        public int ResultId { get; set; }
        public  int TicketId { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public TimeSpan TotalHoras { get; set; }
        public TimeSpan TotalHorasDiaria { get; set; }
    }
}
