﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQSample.Producer.Models
{
    public class ExampleMessageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }
        public decimal Decimal { get; set; }
    }
}
