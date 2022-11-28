using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public class LinuxFileSystemReceiver : IFileSystemReceiver
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing file in Linux OS");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening file in Linux OS");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writting file in Linux OS");
        }
    }
}
