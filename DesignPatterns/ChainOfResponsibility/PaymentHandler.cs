﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
