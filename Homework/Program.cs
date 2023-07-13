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
    if(number_s > max)
    {
        max = number_s;
    } 
    if(number_t > max)
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
    if(num % 2 == 0)
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
        if(counter % 2 == 0)
        {
            Console.Write(counter + " ");
        }
        counter++;
    }
}
//Task8();