using System;

namespace Creational_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Company ForextCompany = Company.GetInstance;
            ForextCompany.PrintDetails("Forex high risk!");

            Company BankCompany = Company.GetInstance;
            BankCompany.PrintDetails("Bank minumum risk Ecvironment ");

            Console.ReadLine();
        }
    }
}
