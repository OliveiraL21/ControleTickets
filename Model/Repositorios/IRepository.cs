using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositorios
{
    public interface IRepository
    {
        public bool InserirTicket(Ticket ticket);
        public IEnumerable<Ticket> Get(Ticket ticket);
        public IEnumerable<Ticket> GetByDate(Ticket ticket);
        public IEnumerable<Ticket> GetTickets();
        public bool EditTicket(Ticket ticket);
        public bool DeleteTicket(Ticket ticket);
    }
}
