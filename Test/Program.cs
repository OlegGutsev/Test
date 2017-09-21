using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Programm
    {
        private const int B = 5;
        private readonly int A;

        public Programm(int a)
        {
            A = replaceA(a);
        }

        public int returnA()
        {
            return A;
        }
        public int replaceA(int a)
        {
            int b;
            return b =  new Programm(a).returnA();
        }

        static void Main(string[] args)
        {
            Programm a = new Programm(5);
            Console.WriteLine(a.returnA());
            int b = a.replaceA(6);
            Console.WriteLine(a.returnA());

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(((10200 * i) + 1) / 1001.0);
            }
            Console.ReadLine();
        }
   
    }
}
