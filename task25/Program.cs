// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Console.Write("Введите число A: ");
//string inputA = Console.ReadLine();
//Console.Write("Введите степень B (натуральное число): ");
//string inputB = Console.ReadLine();
//double A;
//int B;
//A = Convert.ToDouble(inputA);
//B = Convert.ToInt32(inputB);
//double result = 1;
//for (int i = 0; i < B; i++)
//{
//result *= A;
//}
//Console.WriteLine($"{A} в степени {B} равно {result}");


Console.Write("Введите число A: ");
string inputA = Console.ReadLine();
Console.Write("Введите степень B (натуральное число): ");
string inputB = Console.ReadLine();
double A = Convert.ToDouble(inputA);
int B = Convert.ToInt32(inputB);
if (B > 0)
{double result = 1;
for (int i = 0; i < B; i++)
{
result *= A;
}
Console.WriteLine($"{A} в степени {B} равно {result}");
}
else
{
Console.WriteLine("B должно быть натуральным числом (положительным целым числом).");
}

