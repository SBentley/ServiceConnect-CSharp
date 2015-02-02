﻿using System;
using R.MessageBus;

namespace RoutingSlip.Endpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Endpoint 1 ***********");
            var bus = Bus.Initialize(x =>
            {
                x.ScanForMesssageHandlers = true;
            });
            bus.StartConsuming();

            Console.ReadLine();
        }
    }
}
