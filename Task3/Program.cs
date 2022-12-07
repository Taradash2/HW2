Console.Clear();

Console.Write("Введите число дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
Console.Write("Вы ошиблись!\nВведите число дня недели: ");
n = Convert.ToInt32(Console.ReadLine());
}

/*if (n == 1)
Console.WriteLine("нет");
else if (n == 2)
Console.WriteLine("нет");
else if (n == 3)
Console.WriteLine("нет");
else if (n == 4)
Console.WriteLine("нет");
else if (n == 5)
Console.WriteLine("нет");
else if (n == 6)
Console.WriteLine("да");
else
Console.WriteLine("да");*/

if (n <= 7 && n > 5) 
Console.WriteLine("Yes");
else
Console.WriteLine("no");