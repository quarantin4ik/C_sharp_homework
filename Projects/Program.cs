
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

    double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
    result = Math.Round(result,2);
    Console.WriteLine($"Расстояние между точками: {result}");



}

Console.Clear();
Task21();