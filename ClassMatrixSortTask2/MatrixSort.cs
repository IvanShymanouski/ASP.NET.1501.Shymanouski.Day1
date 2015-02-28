using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrixSortTask2
{
    public class MatrixSort
    {


        private static int[] index;
        /// <summary>
        /// Sort strings of matrix by custom function and custom selector
        /// </summary>
        /// <param name="array"></param>
        /// <param name="selector">for example: i => i.Max() </param>
        /// <param name="compare">set the rule of following for near lines
        ///                       for exemple: (i, j) => { return i > j; }
        ///                       it's for sorting according to decrease</param>
        /// <returns>new sort array</returns>
        public static int[][] Sort(int[][] array, Func<int[],int>selector, Func<int,int,bool>compare)
        {
            //preparation time variables
            int[] temp=new int[array.Length];
            index = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = selector(array[i]);
                index[i] = i;
            }

            //sort strings of array by  changing of indexes
            for (int i = 1; i < temp.Length; i++)
            {
                for (int j = 0; j < temp.Length-i; j++)
                {
                    if (compare(temp[index[j]], temp[index[j+1]]))
                    {
                        int swap = index[j+1];
                        index[j+1] = index[j];
                        index[j] = swap;
                    }
                }
            }
            //Qsort(temp, 0, array.Length - 1, selector, compare);

            //create new array from sorted indexes
            int[][] newArray = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                int idx = array.Length - 1 - i;
                newArray[idx] = new int[array[index[i]].Length];
                for (int j = 0; j < array[index[i]].Length; j++)
                {
                    newArray[idx][j] = array[index[i]][j];
                }
            }

            return newArray;
        }

        private static void Qsort(int[] array, int left, int right, Func<int[], int> selector, Func<int, int, bool> compare)
        {
            int i = left;
            int j = right;
            int medium = array[(left + right) / 2];

            while (i <= j)
            {
                while (compare(array[index[i]],medium)) i++;
                while (compare(medium,array[index[j]])) j--;
                if (i <= j)
                {
                    int temp = index[i]; 
                    index[i] = index[j]; 
                    index[j] = temp;
                    i++; j--;
                }
            }
            if (left < j) Qsort(array, left, j, selector, compare);
            if (i < right) Qsort(array, i, right, selector, compare);
        }
    }
}
