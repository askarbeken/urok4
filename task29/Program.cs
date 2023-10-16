// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
Console.Write($"Введите элемент {i + 1}: ");
string input = Console.ReadLine();
int element = Convert.ToInt32(input);
array[i] = element;
}
Console.WriteLine("Элементы массива:");
for (int i = 0; i < array.Length; i++)
{
Console.WriteLine($"Элемент {i + 1}: {array[i]}");
}