﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class MicrowaveCommand : ICommand
    {
        Microwave microwave;
        int time;
        public MicrowaveCommand(Microwave m, int t)
        {
            microwave = m;
            time = t;
        }
        public void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }

        public void Undo()
        {
            microwave.StopCooking();
        }
    }
}
