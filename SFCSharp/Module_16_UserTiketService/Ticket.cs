﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module_16_UserTiketService
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Ticket(int id, string description, int price)
        {
            this.Id = id;
            this.Description = description;
            this.Price = price;
        }
    }
}