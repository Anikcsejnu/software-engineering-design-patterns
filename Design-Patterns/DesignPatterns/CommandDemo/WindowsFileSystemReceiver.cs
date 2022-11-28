using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public class WindowsFileSystemReceiver: IFileSystemReceiver
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing file in Windows OS");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening file in Windows OS");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writting file in Windows OS");
        }
    }
}
