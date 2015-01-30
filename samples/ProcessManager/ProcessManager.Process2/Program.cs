﻿using System;
using R.MessageBus;
using R.MessageBus.Interfaces;

namespace ProcessManager.Process2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** ProcessManager.Process2 ***********");
            IBus bus = Bus.Initialize(config =>
            {
                config.ScanForMesssageHandlers = true;
            });
            bus.StartConsuming();
        }
    }
}
