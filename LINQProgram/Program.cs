using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            divisible(a);
            int[] ar = new int[10] { 1, 3, 5, 7, -1, -4, -6, -9, 11, 10 };
            positive(ar);
            int[] arr = new int[] { 1, 6, 3, 7, 5, 9, 8};
            square(arr);
            int[] array = new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 6, 7, 8, 5, 7, 5, 2 };
            count(array);

            //Console.WriteLine();
            freqChar("helloohelloo");

        }

        public static void divisible(int[] a)
        {
            var nquary = from num in a
                         where (num % 2 == 0)
                         select num;

            Console.WriteLine("Number divisible by 2");
            foreach (int num in nquary)
            {
                Console.WriteLine("{0}", num);
            }
        }


        public static void positive(int[] a)
        {
            var pos = from num in a
                      where num > 0
                      where num < 12
                      select num;

            Console.WriteLine("Positive number between 1 to 12");
            foreach (int num in pos)
            {
                Console.WriteLine(num);
            }

        }


        public static void square(int[] a)
        {
            var squ = from int num in a
                      let sq = num * num
                      where sq > 20
                      select new { num, sq};

            Console.WriteLine("Square no greater than 25");
            foreach(var i in squ)
            {
                Console.WriteLine(i);
            }

        }


        public static void count(int[] a)
        {
            var frq = from num in a
                      group num by num into y
                      select y;

            Console.WriteLine("Number and count");
            foreach (var num in frq)
            {
                Console.WriteLine(num.Key + " === " + num.Count());
            }
        }


        public static void freqChar(string s)
        {
            var freq = from x in s
                       group x by x into y
                       select y;

            Console.WriteLine("Character and count");
            foreach(var x in freq)
            {
                Console.WriteLine(x.Key + " === " + x.Count());
            }

        }
        
    }
}
