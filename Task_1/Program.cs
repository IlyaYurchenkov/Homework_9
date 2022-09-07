// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
Console.Clear();
int n = ReadInt("Введите число n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
