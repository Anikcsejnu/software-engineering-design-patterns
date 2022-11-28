using System;

namespace CommandDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create receiver object
            IFileSystemReceiver fs = new LinuxFileSystemReceiver();

            // define invoker
            FileInvoker fileInvoker;

            // Create command and associate with receiver

            OpenFileCommand openFileCommand = new OpenFileCommand(fs);
            fileInvoker = new FileInvoker(openFileCommand);
            fileInvoker.Execute();

            WriteFileCommand writeFileCommand = new WriteFileCommand(fs);
            fileInvoker = new FileInvoker(writeFileCommand);
            fileInvoker.Execute();

            CloseFileCommand closeFileCommand = new CloseFileCommand(fs);
            fileInvoker = new FileInvoker(closeFileCommand);
            fileInvoker.Execute();
        }
    }
}
