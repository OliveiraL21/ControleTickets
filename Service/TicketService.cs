using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TicketService
    {
        private TicketDAL ticketDAL;
        public TicketService()
        {
            ticketDAL = new TicketDAL();
        }
        public bool InserirTicket(Ticket ticket)
        {
            var result = ticketDAL.InserirTicket(ticket);
            return result;
        }
        public IEnumerable<Ticket> GetTickets()
        {
            var result = ticketDAL.GetTickets();
            return result;
        }
    }
}
