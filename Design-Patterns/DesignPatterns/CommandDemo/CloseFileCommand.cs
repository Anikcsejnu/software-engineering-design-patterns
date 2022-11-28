using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public class CloseFileCommand: ICommand
    {
        private IFileSystemReceiver _fileSystemReceiver;

        public CloseFileCommand(IFileSystemReceiver fs)
        {
            _fileSystemReceiver = fs;
        }
        public void Execute()
        {
            _fileSystemReceiver.CloseFile();
        }
    }
}
