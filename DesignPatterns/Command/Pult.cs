using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Pult
    {
        ICommand command;

        public Pult() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton()
        {
            if (command != null)
                command.Execute();
        }
        public void PressUndo()
        {
            if (command != null)
                command.Undo();
        }
    }
}
