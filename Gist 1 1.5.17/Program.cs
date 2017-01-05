using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gist_1_1._5._17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<T> number = new List<T>();

            for (int i = 0; i <= 100; i++)
            {
                T num = new T();
                if (i % 2 == 0)
                {
                    number.Add(num);
                    Console.WriteLine(i);
                    Console.ReadLine();                 
                }
            }

            for (int i = 0; i <= 100; i++)
            {
                T num = new T();
                if (i % 2 == 0)
                {
                    number.Add(num);
                    Console.ReadLine();
                    if (i % 10 != 0)
                    {
                        number.Remove(num);
                        Console.WriteLine(i);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

    class T
    {
        public T() { }
    }
  

