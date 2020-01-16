using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
   public class SupportTickets
    {
        public class TicketTypes
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public string Code { get; set; }
            public string Flag { get; set; }
        }
    }
}
