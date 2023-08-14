using System;
using MyLib;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {

            void Task31()
            {
                //Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
                //Найдите сумму отрицательных и положительных элементов массива.

                int size = 12; //MyLibClass.Input("Введите размер массива: ");

                int[] numbers = new int[size];

                MyLibClass.FillArray(numbers, -9, 9);
                MyLibClass.PrintArray(numbers);


                Console.WriteLine($"Сумма положительных элементов равна: {MyLibClass.SumPositive(numbers)}");
                Console.WriteLine($"Сумма отрицательных элементов равна: {MyLibClass.SumNegative(numbers)}");

            }

            void Task32()
            {
                //Задача 32: Напишите программу замены элементов массива: положительные элементы замените на
                //соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

                int size = MyLibClass.Input("Введите размер массива: ");
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers, -10, 10);
                MyLibClass.PrintArray(numbers);

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= -1;
                }
                MyLibClass.PrintArray(numbers);

            }

            void Task33()
            {
                //Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
                int size = MyLibClass.Input("Введите размер массива: ");
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers, -10, 10);
                MyLibClass.PrintArray(numbers);
                int num = MyLibClass.Input("Введите число: ");
                bool find = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == num)
                    {
                        find = true;
                    }
                }
                if (find)
                {
                    Console.WriteLine($"Число {num} присутствует в данном массиве!");
                }
                else
                {
                    Console.WriteLine($"Число {num} отсутствует в данном массиве!");
                }


            }

            void Task35()
            {
                //Задача 35: Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива,
                // значения которых лежат в отрезке [10,99]. 

                int size = 10;
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers, -50, 100);
                MyLibClass.PrintArray(numbers);

                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] >= 10 && numbers[i] <= 99) count++;
                }
                Console.WriteLine($"Найдено элементов: {count}");

            }

            void task37()
            {
                //Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
                // второй и предпоследний и т.д. Результат запишите в новом массиве.

                int size = 7;
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers, 0, 15);
                MyLibClass.PrintArray(numbers);

                int lastIndex = numbers.Length - 1;
                int halfIndex = numbers.Length / 2;
                for (int i = 0; i < halfIndex; i++)
                {
                    Console.WriteLine($"{numbers[i]} * {numbers[lastIndex - i]} = {numbers[i] * numbers[lastIndex - i]}");
                }
                if (numbers.Length % 2 == 1)
                {
                    Console.WriteLine($"Элемент {numbers[halfIndex]} без пары");
                }
            }

            void Task39()
            {
                //Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
                //месте, а первый - на последнем и т.д.)

                int size = 7;
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers);
                MyLibClass.PrintArray(numbers);

                int halfIndex = numbers.Length / 2;
                int lastIndex = numbers.Length - 1;
                for (int i = 0; i < halfIndex; i++)
                {
                    // int temp = numbers[i];                   //переворот массива с помощью 3й переменной
                    // numbers[i] = numbers[lastIndex - i];
                    // numbers[lastIndex - i] = temp;

                    (numbers[i], numbers[lastIndex - i]) = (numbers[lastIndex - i], numbers[i]); //способ переворота массива
                    //при помощи кортежа
                }
                MyLibClass.PrintArray(numbers);
            }

            void Task40()
            {
                //Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
                //может ли существовать треугольник со сторонами такой длины.

                int A = MyLibClass.Input("Введите сторону A: ");
                int B = MyLibClass.Input("Введите сторону B: ");
                int C = MyLibClass.Input("Введите сторону C: ");
                if (A < B + C && B < A + C && C < A + B)
                {
                    Console.WriteLine("Такой треугольник существует");
                }
                else Console.WriteLine("Такого треугольника быть не может!");

            }

            void Task42()
            {
                //Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
                // int number = MyLibClass.Input("Введите число: ");
                // int result = 0;
                // int bias = 1;

                // while (number > 0)
                // {
                //     result += number % 2 * bias;
                //     number /= 2;
                //     bias *= 10;
                // }
                // Console.WriteLine(result);

                int number = MyLibClass.Input("Введите число: ");
                string result = "";

                while (number > 0)
                {
                    result = number % 2 + result;
                    number /= 2;
                }
                Console.WriteLine(result);

            }

            void Task44()
            {
                //Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

                int N = MyLibClass.Input("Введите число: ");
                int A = 0;
                int B = 1;
                //int sum = 0;
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"{i}. {A}");
                    // Console.WriteLine(A);
                    // sum = A + B;
                    // B = A;
                    // A = sum;
                    (A, B) = (B, A + B);
                }


            }

            void Task45()
            {
                //Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного
                //копирования.

                int size = 7;
                int[] numbers = new int[size];
                MyLibClass.FillArray(numbers);
                MyLibClass.PrintArray(numbers);
                int[] copyNumbers = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    copyNumbers[i] = numbers[i];
                }
                MyLibClass.PrintArray(copyNumbers);

            }

            void Task46()
            {
                //Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

                //int size = 8;
                int rows = 4;
                int columns = 5;
                //int[] numbers = new int[size];
                //string[] words = new string[size];
                int[,] matrix = new int[rows, columns];
                Random random = new Random();
                //0 = строка
                //1 = столбец
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        //Console.WriteLine($"matrix[{i}, {j}]");
                        matrix[i, j] = random.Next(-10, 10);
                    }
                    //Console.WriteLine($"Вывод строки с инуксом {i} окончен\n");
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }

            void Task48()
            {
                //Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
                //Выведите полученный массив на экран.
                int m = 3;
                int n = 4;
                int[,] matrix = new int[m, n];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = i + j;
                    }
                }
                MyLibClass.PrintArray(matrix);

            }

            void Task49()
            {
                //Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
                // и замените эти элементы на их квадраты.
                int rows = MyLibClass.Input("Введите количество строк: ");
                int columns = MyLibClass.Input("Введите количество столбцов: ");
                int[,] matrix = new int[rows, columns];
                MyLibClass.FillArray(matrix);
                MyLibClass.PrintArray(matrix);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            matrix[i, j] *= matrix[i, j];
                        }
                    }

                }
                Console.WriteLine();
                MyLibClass.PrintArray(matrix);

            }

            void Task51()
            {
                //Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
                //находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

                // int rows = MyLibClass.Input("Введите количество строк: ");
                // int columns = MyLibClass.Input("Введите количество столбцов: ");
                // int sum = 0;
                // int[,] matrix = new int[rows,columns];
                // MyLibClass.FillArray(matrix);
                // MyLibClass.PrintArray(matrix);
                // for (int i = 0; i < matrix.GetLength(0); i++)
                // {
                //     for (int j = 0; j < matrix.GetLength(1); j++)
                //     {
                //         if (i == j)
                //         {
                //             sum += matrix[i, j];
                //         }
                //     }

                // }
                // Console.WriteLine();
                // Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
                //MyLibClass.PrintArray(matrix);

                int rows = MyLibClass.Input("Введите количество строк: ");
                int columns = MyLibClass.Input("Введите количество столбцов: ");

                int[,] matrix = new int[rows, columns];
                MyLibClass.FillArray(matrix, 0, 6);
                MyLibClass.PrintArray(matrix);
                int sum = 0;
                //да    //нет
                int minSize = rows < columns ? rows : columns;
                // if (matrix.GetLength(0) < matrix.GetLength(1))
                // {
                //     minSize = matrix.GetLength(0);
                // }
                // else minSize = matrix.GetLength(1);

                for (int i = 0; i < matrix.GetLength(0); i++)
                {

                    sum += matrix[i, i];

                }
                Console.WriteLine();
                Console.WriteLine($"Сумма элементов главной диагонали = {sum}");

            }

            void Task53()
            {
                //Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю
                // строку массива.
                int rows = 4;
                int columns = 5;
                int[,] matrix = new int[rows, columns];
                MyLibClass.FillArray(matrix, 0, 9);
                MyLibClass.PrintArray(matrix);

                int indexFirstRow = 0;
                int indexLastRow = matrix.GetLength(0) - 1;

                for (int j = 0; j < columns; j++)
                {
                    int temp = matrix[indexFirstRow, j];
                    matrix[indexFirstRow, j] = matrix[indexLastRow, j];
                    matrix[indexLastRow, j] = temp;
                }
                Console.WriteLine();
                MyLibClass.PrintArray(matrix);

            }

            void Task55()
            {
                // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
                // В случае, если это невозможно, программа должна вывести сообщение для пользователя.

                int rows = 3;
                int columns = rows;
                int[,] matrix = new int[rows, columns];
                MyLibClass.FillArray(matrix, 0, 9);
                MyLibClass.PrintArray(matrix);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = i; j < columns; j++)
                    {
                        // int temp = matrix[i, j];
                        // matrix[i, j] = matrix[j, i];
                        // matrix[j, i] = temp;
                        (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
                    }
                }
                Console.WriteLine();
                MyLibClass.PrintArray(matrix);
            }

            void Task57()
            {
                //Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
                //информацию о том, сколько раз встречается элемент входных данных.

                int rows = 4;
                int columns = 5;
                int[,] matrix = new int[rows, columns];

                int a = -5;
                int b = -1;
                MyLibClass.FillArray(matrix, a, b);
                MyLibClass.PrintArray(matrix);
                int size = b - a + 1;
                int[] dict = new int[size];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        dict[matrix[i, j] - a]++;
                    }

                }

                Console.WriteLine();
                for (int i = 0; i < size; i++)
                {
                    if (dict[i] != 0) Console.WriteLine($"Элемент {i + a} встречается {dict[i]} раз(-а).");
                }
            }

            void Task59()
            {
                //Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
                // на пересечении которых расположен наименьший элемент массива.

                int rows = 5;
                int columns = 6;
                int[,] matrix = new int[rows, columns];
                MyLibClass.FillArray(matrix, -100, 100);
                MyLibClass.PrintArray(matrix);

                int rowsResult = rows - 1;
                int columnsResult = columns - 1;
                int[,] result = new int[rowsResult, columnsResult];

                int minValue = matrix[0, 0];
                int i_min = 0;
                int j_min = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] < minValue)
                        {
                            minValue = matrix[i, j];
                            i_min = i;
                            j_min = j;
                        }
                    }

                }
                Console.WriteLine();
                Console.WriteLine($"Минимальное значение {minValue} находится в позиции {i_min + 1}, {j_min + 1}");

                int bias_i = 0;
                int bias_j = 0;
                for (int i = 0; i < rowsResult; i++)
                {
                    if (i == i_min) bias_i++;
                    bias_j = 0;
                    for (int j = 0; j < columnsResult; j++)
                    {
                        if (j == j_min) bias_j++;
                        result[i, j] = matrix[i + bias_i, j + bias_j];
                    }

                }
                Console.WriteLine();
                MyLibClass.PrintArray(result);


            }

            void Task63()
            {
                //Задача 63: Задайте значение N. Напишите программу, которая выведет все 
                //натуральные числа в промежутке от 1 до N. 

                int number = MyLibClass.Input("Введите число: ");
                int count = 1;

                while (count <= number)
                {
                    Console.WriteLine(count);
                    count++;
                }
            }

            void Recursion63(int count, int number)
            {
                if (count > number) return;
                Console.WriteLine(count);
                count++;
                Recursion63(count,number);

            }

            void Recursion65(int m, int n)
            {
                //Задача 65: Задайте значения M и N. Напишите программу, которая 
                //выведет все натуральные числа в промежутке от M до N.
                if (n < m) return;
                Console.WriteLine(m);
                m++;
                Recursion65(m,n);
            }

            int Recursion67(int number, int sum = 0)
            {   
                //Задача 67: Напишите программу, которая будет принимать на вход число и
                //возвращать сумму его цифр.
                if (number == 0)
                {
                    return sum;
                }

                sum += number % 10;
                number /= 10;
                
                return Recursion67(number,sum);
            }
            // Console.Clear();
            
            // int number = MyLibClass.Input("Введите число: ");
            // int sum = Recursion67(number);
            // Console.WriteLine($"Сумма цифр числа {number} равна {sum}");


            int Recursion69(int a, int b, int result = 1)
            {
                //Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
                //возводит число А в целую степень B с помощью рекурсии.
                if (b == 0) return result;

                result *= a;
                b--;

                return Recursion69(a,b,result);
            }

            Console.Clear();
            
            int a = MyLibClass.Input("Введите число a: ");
            int b = MyLibClass.Input("Введите число b: ");
            Console.WriteLine($"{a}^{b} = {Recursion69(a,b)}");




        }

    }
}
