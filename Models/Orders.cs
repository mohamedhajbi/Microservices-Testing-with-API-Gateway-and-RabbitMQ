﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public DateTime OrderDate { get; }
        public string? CustomerName { get; set; }
        public int ProductId { get; set; }
    }
}
