Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n / 100 == 0)
 Console.WriteLine("Нет 3ей цифры");

else
{
int n1 = n % 1000;
int n2 = n1 / 100;

Console.WriteLine(n2);
}