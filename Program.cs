int number = 67;
System.Console.WriteLine(number);
string n = number.ToString();
Console.WriteLine("Введите ваше имя");
string name = Console.ReadLine();       // Отдает все только строкой
Console.WriteLine("Введите чисо a ");
int a = int.Parse(Console.ReadLine());  
Console.WriteLine("Введите чисо b ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(a + b); 

if (a > b)
{
Console.WriteLine("Число a больше числа b");
} else {
    if (a < b) {
        Console.WriteLine("Число b больше числа a");
    } else {
        Console.WriteLine("Число a равно числу b");
    }
}