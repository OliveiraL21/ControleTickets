﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface ITicketService
    {
        IList<Ticket>FilterTickets(Ticket ticket);
    }
}
