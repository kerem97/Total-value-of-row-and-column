using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2];
            int[] total = new int[10];
            
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write("x[{0},{1}] :" , i, k);
                    array[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
          
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    total[i] = total[i] + array[i, k];

                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}.satırın toplamı ={1}", i + 1, total[i]);
            }
            Console.ReadKey();







        }
    }
}
