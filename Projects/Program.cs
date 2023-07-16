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




Task9();