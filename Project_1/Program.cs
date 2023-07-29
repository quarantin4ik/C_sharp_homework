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

            Console.Clear();
            Task45();




        }

    }
}
