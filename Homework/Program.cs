int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task2()
{
    //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    Console.Write("Введите первое число: ");
    int number_f = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number_s = Convert.ToInt32(Console.ReadLine());
    if (number_f > number_s)
    {
        Console.Write(number_f + " Больше. ");
    }
    else
    {
        Console.Write(number_s + " Больше. ");
    }
    if (number_f < number_s)
    {
        Console.Write(number_f + " Меньше. ");
    }
    else
    {
        Console.Write(number_s + " Меньше. ");
    }

}

void Task4()
{
    //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    Console.Write("Введите первое число: ");
    int number_f = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number_s = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int number_t = Convert.ToInt32(Console.ReadLine());
    int max = number_f;
    if (number_s > max)
    {
        max = number_s;
    }
    if (number_t > max)
    {
        max = number_t;
    }

    Console.Write("max = ");
    Console.WriteLine(max);
}

void Task6()
{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
    //(делится ли оно на два без остатка).
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.Write(num + " чётное ");
    }
    else
    {
        Console.Write(num + " нечётное ");
    }
}

void Task8()
{
    //Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int counter = 1;
    while (counter <= num)
    {
        if (counter % 2 == 0)
        {
            Console.Write(counter + " ");
        }
        counter++;
    }
}

void Task10()
{
    //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
    //цифру этого числа.

    int number = Input("Введите трёхзначное число: ");
    int number_f = number / 10;
    int number_s = number_f % 10;
    Console.WriteLine($"Вторая цифра вашего числа = {number_s}");
}

void Task13()
{
    //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или
    //сообщает, что третьей цифры нет.

    int number = Input("Введите число: ");
    if (number > 99)
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine($"Третья цифра вашего числа = {number % 10}");
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }

}

void Task15()
{
    //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
    //является ли этот день выходным.

    int num = Input("Введите номер дня: ");
    if (num == 1)
    {
        Console.WriteLine("Будний день");
    }
    else if (num == 2)
    {
        Console.WriteLine("Будний день");
    }
    else if (num == 3)
    {
        Console.WriteLine("Будний день");
    }
    else if (num == 4)
    {
        Console.WriteLine("Будний день");
    }
    else if (num == 5)
    {
        Console.WriteLine("Будний день");
    }
    else if (num == 6)
    {
        Console.WriteLine("Выходной");
    }
    else if (num == 7)
    {
        Console.WriteLine("Выходной");
    }
    else if (num >= 8)
    {
        Console.WriteLine("Нет такого дня!!!");
    }

}

Console.Clear();
Task15();