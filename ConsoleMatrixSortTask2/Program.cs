using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMatrixSortTask2;

namespace ConsoleMatrixSortTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int xSize=10;

            int[][] matrix = new int[xSize][];
            Random random = new Random();

            for (int i = 0; i < xSize; i++)
            {
                int ySize = random.Next(1,11);
                matrix[i] = new int[ySize];
                for (int j = 0; j < ySize; j++)
                {
                    matrix[i][j] = random.Next(0,1000);
                }
            }

            Console.WriteLine("The initial matrix: ");
            foreach (var i in matrix)
            {
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
           
            Func<int[],int> selector=i => i.Max();
            Func<int, int, bool> compare = (i, j) => { return i > j; };

            int[][] newMatrix = MatrixSort.Sort(matrix, selector , compare);

            Console.WriteLine("The initial matrix after sorting: ");
            foreach (var i in matrix)
            {
                Console.Write(selector(i) + " - ");
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("The sort matrix: ");
            foreach (var i in newMatrix)
            {
                Console.Write(selector(i) + " - ");
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
