using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите числовой номер");
            //int numInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите баланс");
            //double balance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите Имя");
            //string name = Console.ReadLine();
            //Accounts<int> accounts1 = new Accounts<int>(numInt,balance,name);
            //Console.WriteLine(accounts1.GetInfo());

            //Console.WriteLine("Введите строковый номер");
            //string numString = Console.ReadLine();
            //Console.WriteLine("Введите баланс");
            //balance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите Имя");
            //name = Console.ReadLine();
            //Accounts<string> accounts2 = new Accounts<string>(numstring,balance,name);
            //Console.WriteLine(accounts2.GetInfo())

            Accounts<int> accounts1 = new Accounts<int>();
            accounts1.Input();
            Console.WriteLine(accounts1.GetInfo());

            Accounts<string> accounts2 = new Accounts<string>();
            accounts2.Input();
            Console.WriteLine(accounts2.GetInfo());
            Console.ReadKey();
        }
    }
}
