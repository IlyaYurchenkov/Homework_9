// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp=0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}