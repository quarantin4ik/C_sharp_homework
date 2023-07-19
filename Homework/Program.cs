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

void Task19()
{
    //Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    int number = Input("Введите пятизначное число: ");
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Введено не пятизначное число");
    }
    else
    {
        int num_f = number / 10000;
        int num_s = number / 1000 % 10;
        int num_t = number / 10 % 10;
        int num_q = number % 10;
        if (num_f == num_q && num_s == num_t)
        {
            Console.WriteLine($"{number} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"{number} Не является палиндромом.");
        }
    }

}

void Task21()
{
    //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
    //ними в 3D пространстве.
    int x1 = Input("Введите X первой точки: ");
    int y1 = Input("Введите Y первой точки: ");
    int z1 = Input("Введите Z первой точки: ");
    int x2 = Input("Введите X второй точки: ");
    int y2 = Input("Введите Y второй точки: ");
    int z2 = Input("Введите Z второй точки: ");

    double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    result = Math.Round(result,2);
    Console.WriteLine($"Расстояние между точками: {result}");
}

void Task23()
{
    //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    int N = Input("Введите число: ");
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
    }
}

void Task25()
{
    //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два
    //натуральных числа (A и B) и возводит число A в степень B.

    int A = Input("Введите число: ");
    int B = Input("Введите степень: ");
    int result = 1;
    if (A <= 0 || B <= 0)
    {
        Console.WriteLine("Ошибка ввода!");
    }
    else
    {
        for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
        Console.WriteLine($"{A}^{B} = {result}");
    }
}

void Task27()
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    int number = Input("Введите число: ");
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");

}

void Task29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный
    //по модулю массив.

    int size = 8;
    Random rnd = new Random();
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rnd.Next(0, 101);
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < size; j++)
        {
            if(numbers[j] < numbers[minPosition])
            {
                minPosition = j;
            } 
        }

        int temporary = numbers[i];
        numbers[i] = numbers[minPosition];
        numbers[minPosition] = temporary;
        Console.Write($"{numbers[i]} ");
    }
    
}   


int task = Input("Введите номер задачи: ");
switch (task)
{
    case 2:
        Task2();
        break;
    case 4:
        Task4();
        break;
    case 6:
        Task6();
        break;
    case 8:
        Task8();
        break;
    case 10:
        Task10();
        break;
    case 13:
        Task13();
        break;
    case 15:
        Task15();
        break;
    case 19:
        Task19();
        break;
    case 21:
        Task21();
        break;
    case 23:
        Task23();
        break;
    case 25:
        Task25();
        break;
    case 27:
        Task27();
        break;
    case 29:
        Task29();
        break;
    default:
        Console.WriteLine("Ошибка ввода");
        break;
}
//Console.Clear();
//Task23();