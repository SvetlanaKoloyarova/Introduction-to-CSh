//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write ("Input your 1st number:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input your 2st number:");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine ($"Max = {num_1}, Min = {num_2}");
}
else
{
    Console.WriteLine ($"Max = {num_2}, Min = {num_1}");
}
*/


//Задача 4.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write ("Input your 1st number:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input your 2st number:");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input your 3st number:");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (max < num_2)
{
        max = num_2;
        if (max < num_3)
        {
            Console.WriteLine (max = num_3);
        }
        else
        {
            Console.WriteLine (max = num_2);
        }
}
else
{
    if (max < num_3)
    {
        Console.WriteLine (max = num_3);
    }
    else
    {
        Console.WriteLine (max = num_1);
    }
}
*/


//Задача 6.
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write ("Input your number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine ($"Your number {number} - четное");
}
else
{
    Console.WriteLine ($"Your number {number}  - нечетное");
}
*/


//Задача 8.
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Input your number:");
int num_N = Convert.ToInt32(Console.ReadLine());

int current_i = 1;

while (current_i <= num_N)
{
    Console.Write (current_i + 1 +" ");
    current_i += 2;
    
}



