﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CQRS.Commands.ProductCommands
{
    public class UpdateProductCommand
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}