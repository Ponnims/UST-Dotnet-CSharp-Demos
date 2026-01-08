using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class ArrayDemos
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5] { 90, 80, 70, 60, 50 }; // fixed size array
            int[] marks = new int[] { 85, 75, 65, 55, 45, 89, 90, 56 }; // Dynamic Array
            int[] grades = { 95, 85, 75, 65, 55, 56, 78 }; // Implicitly typed array


            for (int i= 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Scores[{i}] = {scores[i]}");
            }

            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }


            //1. Single Dimensional Array
            //2. Multi Dimensional Array
            //3. Jagged Array

            string[] empnameslist = new string[3] {"Msp","Raja","Sai" };

            int[,] matr = new int[2, 2] { {1,2 },{3,4 } };
            int[,] samp = new int[3, 2] { {1,2 },{3,4 },{5,6 } };
            int[,] samp1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };


            int[][] jagged = new int[3][];

            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[3] { 3, 4, 5 };
            jagged[2] = new int[4] { 6, 7, 8, 9 };

            Console.WriteLine(jagged[0][0]);

        }
    }
}
