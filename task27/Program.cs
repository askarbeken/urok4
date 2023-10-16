// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int sum = CalculateDigitSum(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
static int CalculateDigitSum(int n)
{
int sum = 0;
n = Math.Abs(n);
while (n > 0)
{
sum += n % 10;
n /= 10;
}
return sum;
}