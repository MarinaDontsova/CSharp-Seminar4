// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B > 0)
{
    int i = 1;
    int result = A;
    while (i < B)
    {
        result = result * A;
        i++;
    }
Console.Write($"Число {A} в степени {B} равно: ");
Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Степень должна быть натуральным числом");
}
