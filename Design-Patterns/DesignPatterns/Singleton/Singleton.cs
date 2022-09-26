using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    internal sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly Object obj = new Object();
        public static Singleton GetInstance
        {
            get
            {   if (instance == null)
                {

                    lock (obj)
                    {
                        if (instance == null) // double check locking
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value : " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
