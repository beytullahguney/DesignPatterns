using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Singleton
{
    public sealed class Company
    {
        private static int counter = 0;
        private static Company instance = null;

        public static Company GetInstance
        {
            get
            {
                if (instance == null)
                {
                    if (true)
                    {
                        instance = new Company();
                    }
                }
                return instance;
            }
        }

        private Company()
        {
            counter++;
            Console.WriteLine(string.Format("Counter Value : {0}", counter));
        }

        public void PrintDetails(string Message)
        {
            Console.WriteLine(Message);
        }

    }
}
