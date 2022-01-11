﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityModels
{
    public class Logger
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
