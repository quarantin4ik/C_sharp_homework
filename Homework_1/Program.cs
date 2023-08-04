using System;
using MyLib;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            void Task34()
            {
                //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
                //программу, которая покажет количество чётных чисел в массиве.

                int size = 10;
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers, 100, 998);
                MyLibClass.PrintArray(numbers);
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0) count++;
                }
                Console.WriteLine($"Количество четных элементов: {count}");


            }

            void Task36()
            {
                //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с
                //нечётными индексами.
                int size = 6;
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers);
                MyLibClass.PrintArray(numbers);
                int sum = 0;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (i % 2 == 1) sum += numbers[i];
                }
                Console.WriteLine($"Сумма элементов с нечётными индексами: {sum}");

            }

            void Task38()
            {
                //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
                //элементами массива.

                int size = 6;
                double[] numbers = new double[size];
                MyLibClass.FillArray(numbers, -100, 100);
                MyLibClass.PrintArray(numbers);

                double max = numbers[0];
                double min = numbers[0];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max) max = numbers[i];
                    else if (numbers[i] < min) min = numbers[i];
                }
                Console.WriteLine($"Разница между {max} и {min} равна {max - min}");
            }

            void Task41()
            {
                //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
                int size = MyLibClass.Input("Введите количество чисел: ");
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers);
                MyLibClass.PrintArray(numbers);
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0) count++;
                }
                Console.WriteLine($"Количество положительных чисел: {count}");
            }

            void Task43()
            {
                //Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
                // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

                int b1 = MyLibClass.Input("Введите значение b1: ");
                int k1 = MyLibClass.Input("Введите значение k1: ");
                int b2 = MyLibClass.Input("Введите значение b2: ");
                int k2 = MyLibClass.Input("Введите значение k2: ");
                double x = (b2 - b1) / (k1 - k2);
                double y1 = k1 * x + b1;
                double y2 = k2 * x + b2;
                double y = 0;
                if (y1 == y2)
                {
                    y = y1;
                    Console.WriteLine($"Точка пересечения: ({y},{x})");
                }
                else
                {
                    Console.WriteLine("Прямые параллельны");
                }


            }

            void Task47()
            {
                //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами,
                //округлёнными до одного знака.
                int m = MyLibClass.Input("Введите количество строк: ");
                int n = MyLibClass.Input("Введите количество столбцов: ");
                double[,] matrix = new double[m, n];
                MyLibClass.FillArray(matrix);
                MyLibClass.PrintArray(matrix);

            }

            void Task50()
            {
                //Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
                //и возвращает значение этого элемента или же указание, что такого элемента нет.

                int rows = 5;
                int columns = 5;
                int[,] matrix = new int[rows, columns];
                MyLibClass.FillArray(matrix, -30, 30);
                MyLibClass.PrintArray(matrix);
                Console.WriteLine();
                int a = MyLibClass.Input("Введите строку: ");
                int b = MyLibClass.Input("Введите столбец: ");
                if (a > rows || b > columns)
                {
                    Console.WriteLine("Вы вышли за пределы таблицы.");
                }
                else
                {
                    Console.WriteLine(matrix[a - 1, b - 1]);
                }
                // for (int i = 0; i < matrix.GetLength(0); i++)
                // {
                //     for (int j = 0; j < matrix.GetLength(1); j++)
                //     {
                //         if (i + 1 == a && j + 1 == b)
                //         {
                //             Console.WriteLine(matrix[i, j]);
                //         }
                //     }
                //}


            }

            void Task52()
            {
                //Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
                //столбце.
                int rows = MyLibClass.Input("Введите количество строк: ");
                int columns = MyLibClass.Input("Введите количество столбцов: ");

                int[,] matrix = new int[rows, columns];
                MyLibClass.FillArray(matrix, 0, 9);
                MyLibClass.PrintArray(matrix);
                double sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        sum = matrix[i, j] + sum;
                    }
                    Console.WriteLine($"Ср.ар {j + 1} столбца = {sum = sum / rows}");
                    sum = 0;
                }
                Console.WriteLine();
            }

            Console.Clear();
            Task52();

        }
    }
}
