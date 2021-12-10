using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakyika5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите элементы массива  ");
            Console.WriteLine();
            int[,] mass6 = new int[n, n];
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;



            for (int i=0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                    
                {
                    mass6[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
                               
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)

                {
                    Console.Write(mass6[i, j]+"\t");
                   
                   
                    if (i == j) s1 += mass6[i, j]; // Сумма элементов главной диоганали
                    if (j == n - 1) s2 += mass6[i, j]; // Сумма элементов побочной диоганали
                    if (i==i) s3 += mass6[i, j];       // Сумма всех строк массива
                    if (j == j) s4 += mass6[i, j];     // Сумма всех столбцов массива

                }
                Console.WriteLine();

            }
            if (s1 == s2 && s1 == s3 / n && s1 == s4 / n)
            Console.WriteLine("Ваш квадрат получился магическим!!!!");
            else
            {
                Console.WriteLine("Увы -(, но ваш квадрат не магический");
            }

                                  
            Console.ReadKey();


        }
    }
}
