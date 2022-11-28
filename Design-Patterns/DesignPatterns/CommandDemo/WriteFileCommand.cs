using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public class WriteFileCommand: ICommand
    {
        private IFileSystemReceiver _fileSystemReceiver;

        public WriteFileCommand(IFileSystemReceiver fs)
        {
            _fileSystemReceiver = fs;
        }
        public void Execute()
        {
            _fileSystemReceiver.WriteFile();
        }
    }
}
