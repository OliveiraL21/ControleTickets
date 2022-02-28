using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TicketDAL
    {
        private readonly TicketContext _context;
        public TicketDAL()
        {
            _context = new TicketContext();
        }

        public bool InserirTicket(Ticket ticket)
        {
            if(ticket == null)
            {
                return false;
            }
            _context.tickets.Add(ticket);
            _context.SaveChanges();
            return true;
        }
        public IEnumerable<Ticket> GetTickets()
        {
            var result = _context.tickets.ToList();
            return result;
        }
        public bool EditTicket(Ticket ticket)
        {
            var result = _context.tickets.SingleOrDefault(t => t.Codigo == ticket.Codigo);
            if(result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(ticket);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteTicket(Ticket ticket)
        {
            var result = _context.tickets.SingleOrDefault(t => t.Codigo == ticket.Codigo && t.TicketID == ticket.TicketID);
            if(result != null)
            {
                _context.Remove(result);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
