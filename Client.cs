using Module18.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    internal class Client
    {
        private Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand> { };
        

        public void SetCommand(string name, ICommand command)
        {
            Commands[name] = command;
        }

        public void Run(string commandName) 
        {
            Commands[commandName].Execute();
        }


    }
}
