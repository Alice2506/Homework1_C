Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(b);
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine(c);
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное число равно " + max);





