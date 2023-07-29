

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task0()
{
    //Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = number * number;
    Console.WriteLine(result);
}

void Task1()
{
    //Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

    // Console.Write("Введите первое число: ");    //всё это можно сократить!!!
    // string input_f = Console.ReadLine();
    // Console.Write("Введите второе число: ");
    // string input_s = Console.ReadLine();
    // int number_f = Convert.ToInt32(input_f);
    // int number_s = Convert.ToInt32(input_s);


    Console.Write("Введите первое число: ");
    int number_f = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number_s = Convert.ToInt32(Console.ReadLine());
    if (number_f == number_s * number_s)
    {
        Console.WriteLine("Первая переменная является квадратом второй");
    }
    else
    {
        Console.WriteLine("Первая переменная не является квадратом второй");
    }

    //Если number_f == number_s * number_s , то 
    // напечатать "равно"
}

void Task2()
{
    //Напишите программу, которая будет выдавать название дня недели по заданному номеру.

    Console.Write("Введите номер дня: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (num == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (num == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (num == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (num == 5)
    {
        Console.WriteLine("Пяиница");
    }
    else if (num == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (num == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    else if (num >= 8)
    {
        Console.WriteLine("Нет такого дня!!!");
    }

}

void Task5()
{
    //5. Напишите программу вычисления значения функции возведения числа в квадрат.

    int Power(int number)
    {
        int result = number * number;
        return result;
    }
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int result = Power(num);
    Console.WriteLine(result);
}

void Task7()
{
    //7. Напишите программу, которая на вход принимает одно число (N),
    // а на выходе показывает все целые числа в промежутке от -N до N.
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    num = Math.Abs(num);

    int counter = -num;
    //Надо выводить числа пока не достигнем введенного числа
    // 0 1 2 3 4 5 . . . num
    while (counter <= num)
    {
        Console.Write(counter + " ");
        counter++;
    }
}

void Task9()
{
    //Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

    Random rnd = new Random();

    int number = rnd.Next(10, 100);

    Console.WriteLine($"Выпало случайное число: {number}");

    int f_digit = number / 10;  //84 / 10 = 8
    int s_digit = number % 10;  //84 % 10 = 4
                                //Console.WriteLine(f_digit);
                                //Console.WriteLine(s_digit);

    int max;

    if (f_digit > s_digit) max = f_digit;
    else max = s_digit;

    Console.WriteLine($"Наибольшая цифра числа: {max}");

}

void Task11()
{
    //11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

    Random rnd = new Random();

    int number = rnd.Next(100, 1000);

    Console.WriteLine($"Выпало случайное число: {number}");
    int f_digit = number / 100;
    int t_digit = number % 10;
    //f_digit = f_digit % 10;
    //Console.Write(f_digit);
    //Console.Write(t_digit);
    Console.WriteLine($"Ответ: {f_digit}{t_digit}");
    Console.WriteLine($"Ответ: {f_digit * 10 + t_digit}");

}

void Task12()
{
    //12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
    //число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

    Console.Write("Введите первое число: ");
    int number_f = Convert.ToInt32(Console.ReadLine());
    int number_s = Input("Введите второе число: ");
    int div = number_s % number_f;
    if (div == 0)
    {
        Console.WriteLine($"Число {number_s} кратно числу {number_f}");
    }
    else
    {
        Console.WriteLine($"Число {number_s} не кратно числу {number_f}."
                          + $" Остаток от деления равен {div}");
    }
}

void Task14()
{
    //14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
    int number = Input("Введите число: ");
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine($"Число {number} кратно 7 и 23 одновременно.");
    }
    else
    {
        Console.WriteLine($"Число {number} НЕ кратно 7 и 23 одновременно.");
    }
}

void Task16()
{
    //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

    int number_f = Input("Введите число: ");

    int number_s = Input("Введите число: ");

    if (number_f * number_f == number_s || number_s * number_s == number_f)
    {
        Console.WriteLine("Есть квадрат");
    }
    else
    {
        Console.WriteLine("Нет квадрата");
    }

}

void Task17()
{
    //17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
    //номер четверти плоскости, в которой находится эта точка.
    int x = Input("Введите X:");
    int y = Input("Введите Y:");
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка принадлежит первой четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка принадлежит второй четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка принадлежит третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка принадлежит четвертой четверти");
    }
    else
    {
        Console.WriteLine("Точка лежит на оси");
    }
}

void Task18()
{
    //Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
    //возможных координат точек в этой четверти (x и y).
    int number = Input("Введите номер четверти:");
    if (number == 1)
    {
        Console.WriteLine("x > 0; y > 0");
    }
    else if (number == 2)
    {
        Console.WriteLine("x < 0; y > 0");
    }
    else if (number == 3)
    {
        Console.WriteLine("x < 0; y < 0");
    }
    else if (number == 4)
    {
        Console.WriteLine("x > 0; y < 0");
    }
    else
    {
        Console.WriteLine("Такой четверти нет");
    }

}

void Task21()
{
    //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
    //находит расстояние между ними в 2D пространстве.

    int x1 = Input("Введите X первой точки: ");
    int y1 = Input("Введите Y первой точки: ");
    int x2 = Input("Введите X второй точки: ");
    int y2 = Input("Введите Y второй точки: ");

    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    result = Math.Round(result, 2);
    Console.WriteLine($"Расстояние между точками: {result}");

}

void Task22()
{
    //Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    int N = Input("Введите число: ");

    // int i = 1;
    // while(i <= N)
    // {
    //     Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
    //     //Console.WriteLine(i * i);
    //     i++;
    // }
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
    }
}

void Task24()
{
    //Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

    int number = Input("Введите число: ");
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i} + ");
        sum += i;
    }
    Console.Write("\b\b= ");
    Console.WriteLine(sum);
}

void Task26()
{
    //Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

    int number = Input("Введите число: ");
    int count = 0;

    for (int i = number; i > 0; i /= 10)
    {
        count++;
    }
    Console.WriteLine($"Количество цифр в числе {number} = {count}");
}

void Task28()
{
    //Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

    // int N = Input("Введите число: ");


    // for (int i = 1; i <= N; i++)
    // {
    //     Console.WriteLine($"{i}*{N} = {Math.BigMul(i,N)}");
    // }

    int number = Input("Введите число: ");
    int mult = 1;

    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i} * ");
        mult *= i;
    }
    Console.Write("\b\b= ");
    Console.WriteLine(mult);

}

void Task30()
{
    //Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

    int size = 5;
    Random rnd = new Random();
    //0   1  2  3   4   5 - index
    //int[] numbers = {10, 7, 5, 13, 21, 8};
    //Console.WriteLine(numbers[3]);

    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = rnd.Next(0, 2);
    }


    for (int i = 0; i < size; i++)
    {
        // Console.Write($"numbers[{i}] = ");
        // Console.WriteLine(numbers[i]);
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

void Task31()
{
    //Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
    //отрицательных и положительных элементов массива.
    int size = 12;
    int[] numbers = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(-9, 10);
    }



}
Console.Clear();
// int task = Input("Введите номер задачи: ");
// switch (task)
// {
//     case 17:
//         Task17();
//         break;
//     default:
//         Console.WriteLine("Ошибка ввода");
//         break;
// }
// if (task == 17) Task17;
// else if (task == 18) Task18;
Task30();