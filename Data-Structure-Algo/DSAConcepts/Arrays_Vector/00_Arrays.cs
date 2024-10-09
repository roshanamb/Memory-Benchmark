using System;
using System.Text;

namespace DSAConcepts{
    public class Arrays
    {
        int[] arr_1d;
        int[,] arr_2d;
        int[][] jaggedArray = new int[3][];
        public Arrays()
        {
            arr_1d = new int[]{11,22,33,44,55,66,77,88,99,100};
            arr_2d = new int[,]{{11,22,33},{44,55,66},{77,88,99}};

            jaggedArray[0] = new int[5] { 11, 13, 15, 17, 19 };
            jaggedArray[1] = new int[4] { 21, 23, 25, 27 };
            jaggedArray[2] = new int[5] { 31, 33, 35, 37, 39 };
        }

        public void Print()
        {
            #region Simple (1-D) Array
            
            Console.WriteLine("Print 1-D array.........Length is {0}",arr_1d.Length);
            foreach (var item in arr_1d)
            {
                Console.Write(item + " ");
            }

            #endregion Simple (1-D) Array

            #region Multidimentional Array
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Print 2-D array.........Length is {0}",arr_2d.Length);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr_2d[i,j] + " ");
                }
                Console.WriteLine();
            }

            #endregion Multidimentional Array

            #region Jagged Array
            
            Console.WriteLine();
            Console.WriteLine("Print Jagged Array  .........Length is {0}",jaggedArray.Length);      //3
            Console.WriteLine("Print Jagged Array 1.........Length is {0}",jaggedArray[0].Length); //5
            Console.WriteLine("Print Jagged Array 2.........Length is {0}",jaggedArray[1].Length); //4
            Console.WriteLine("Print Jagged Array 3.........Length is {0}",jaggedArray[2].Length); //5
            foreach (var row in jaggedArray)
            {
                foreach (var item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            #endregion Jagged Array
        }
    }
}