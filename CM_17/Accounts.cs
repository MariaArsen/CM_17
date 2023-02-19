using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_17
{
    public class Accounts<T>
    {
        public T Num { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }

        //public Accounts(T num, double balance, string name)
        //{
        //    Num = num;
        //    Balance = balance;
        //    Name = name;
        //}
        public string GetInfo()
        {
            return $"{ Num} {Balance} { Name}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));

            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
        }
    }
}
