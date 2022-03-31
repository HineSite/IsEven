using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("\nDone!");
            Console.ReadLine();
        }

        private Program()
        {
            IsEven(5);
            Console.WriteLine("Even!");
        }

        public void IsEven(int num)
        {
            num /= (++num % 2);
        }
    }
}

