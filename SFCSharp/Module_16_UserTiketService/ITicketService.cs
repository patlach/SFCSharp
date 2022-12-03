using System;
using System.Collections.Generic;
using System.Text;

namespace Module_16_UserTiketService
{
    public interface ITicketService
    {
        int GetTicketPrice(int ticketId);
    }
}
