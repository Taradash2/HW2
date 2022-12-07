Console.Clear();

Console.WriteLine("Введите число: ");
int n =Convert.ToInt32(Console.ReadLine());

if (n % 100 != 0)
Console.WriteLine("Нет Третьей цифры");
else

int n1 = n / 10;
int n2 = n1 % 10;
Console.WriteLine(n2);