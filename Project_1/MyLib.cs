using System;

namespace MyLib
{
    public static class MyLibClass
    {
        public static int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void FillArray(int[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
        }

        public static void FillArray(double[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
                array[i] = Math.Round(array[i], 2);
            }
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }

        public static int SumPositive(int[] numbers)
        {
            int sumPositive = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) sumPositive += numbers[i];
            }
            return sumPositive;
        }

        public static int SumNegative(int[] numbers)
        {
            int sumNegative = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0) sumNegative += numbers[i];
            }
            return sumNegative;
        }

        public static void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(minValue, maxValue);
                    }
                    
                }
        }

        public static void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i,j]}\t");
                    }
                    Console.WriteLine();
                }
        }

        public static void FillArray(double[,] matrix, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
                        matrix[i, j] = Math.Round(matrix[i, j], 1);
                    }
                    
                }
        }

        public static void PrintArray(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i,j]}\t");
                    }
                    Console.WriteLine();
                }
        }



    }
}