using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using Moq;
using NUnit.Framework;

namespace Module_16_UserTiketService.Test
{
    public class TicketPriceTest
    {
        [Test]
        public void TicketPriceMustReturnNotNullableTicket()
        {
            var mockTicketService = new Mock<ITicketService>();
            mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
            mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
            mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

            var ticketPriceTest = new TicketPrice(mockTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
        }
    }
}
