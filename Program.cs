// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

 Console.Write("Input first number: ");
 int a  = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input second number: ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>b)
     Console.Write("a is a max number");
 else 
  Console.Write("b is a max number");

//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

 Console.Write("Input first number: ");
 int a = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input second number: ");
 int b = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input thurd number: ");
 int c = Convert.ToInt32(Console.ReadLine());

 if(a>b)
     Console.Write("max=a");
 else
     if(b<c)
         Console.Write("max=c");
     else
         Console.Write("max =b");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

 Console.Write("Input number: ");
 int number = Convert.ToInt32(Console.ReadLine());

 if(number%2==0)
     Console.Write("An even number");
 else
     Console.Write("The uneven number"); 

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int m=1;
while (m<=n);
{
    if(m % 2==0)
    {
        Console.Write ($"{m}");
    }
    m++;
}
Console.WriteLine();




