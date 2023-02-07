﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_16_UserTiketService
{
    public class TicketService : ITicketService
    {
        public int GetTicketPrice(int ticketId)
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
               throw new TicketNotFoundException() : ticket.Id;
        }

        public Ticket GetTicket(int ticketId)
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
              throw new TicketNotFoundException() : ticket;
        }

        public void SaveTicket(Ticket ticket)
        {
            FakeBaseData.Add(ticket);
        }

        private void DeleteTicket(Ticket ticket)
        {
            FakeBaseData.Remove(ticket); ;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return FakeBaseData;
        }

        public List<Ticket> FakeBaseData = new List<Ticket>()
        {
            new Ticket(1, "Москва - Санкт-Петербург", 3500),
            new Ticket(2, "Челябинск - Магадан", 3500),
            new Ticket(3, "Норильск - Уфа", 3500)
        };
    }
}