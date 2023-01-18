//Задача 8: Напишите программу, которая на вход принимает число (N), а 
//на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите целое число");
int number_1 = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count < number_1)
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
