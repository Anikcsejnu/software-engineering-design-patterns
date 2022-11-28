using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public class OpenFileCommand: ICommand
    {
        private IFileSystemReceiver _fileSystemReceiver;

        public OpenFileCommand(IFileSystemReceiver fs)
        {
            _fileSystemReceiver = fs;
        }
        public void Execute()
        {
            _fileSystemReceiver.OpenFile();
        }
    }
}
