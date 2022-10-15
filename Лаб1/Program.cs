// See https://aka.ms/new-console-template 
int x, y;
Console.WriteLine("Введите x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
y = Convert.ToInt32(Console.ReadLine());

int z = x;
x = y;
y = z;

Console.WriteLine($"x = {x}, y = {y}");

Console.ReadKey();
