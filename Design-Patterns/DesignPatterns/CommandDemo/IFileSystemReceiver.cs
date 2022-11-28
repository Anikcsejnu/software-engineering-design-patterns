using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public interface IFileSystemReceiver
    {
        void OpenFile();
        void WriteFile();
        void CloseFile();
    }
}
