
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warmUp27
{
    class Program
    {
        static void Main(string[] args)
        {

            int ranGen = 0;
            int[] array = new int[8];

            Random ran = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                ranGen = ran.Next(0, 10);

                array[i] = ranGen;
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.ReadKey();
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i] + array[i + 1];


            }



            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[i + 1])
                {
                    array[i] = array[i + 1];
                }

            }


        }
    }
}
