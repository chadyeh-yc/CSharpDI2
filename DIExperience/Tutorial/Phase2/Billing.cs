﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Phase2
{
    public interface IBilling
    {
        void ProcessPayment(OrderInfo orderInfo);
    }
    public class Billing : IBilling
    {
        public void ProcessPayment(OrderInfo orderInfo)
        {
            Console.WriteLine("進行付款");
        }
    }
}
