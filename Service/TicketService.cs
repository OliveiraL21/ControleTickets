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
        public IEnumerable<Ticket> Get(Ticket ticket)
        {
            var result = ticketDAL.Get(ticket);
            return result;
        }
        public IEnumerable<Ticket> GetTickets()
        {
            var result = ticketDAL.GetTickets();
            return result;
        }
        public bool EditTicket(Ticket ticket)
        {
            var result = ticketDAL.EditTicket(ticket);
            return result;
        }
        public bool DeleteTicket(Ticket ticket)
        {
            var result = ticketDAL.DeleteTicket(ticket);
            return result;
        }
    }
}
