using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public class FileInvoker
    {
        ICommand command;
        public FileInvoker(ICommand c)
        {
            command = c;
        }

        public void Execute()
        {
            command.Execute();
        }
    }
}
