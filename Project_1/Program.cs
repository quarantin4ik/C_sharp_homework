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
                    if(numbers[i] == num)
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
                    if(numbers[i] >= 10 && numbers[i] <=99) count++;
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

                int lastIndex = numbers.Length -1;
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

            Console.Clear();
            task37();




        }

    }
}
