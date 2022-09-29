Console.WriteLine ("Вы попали в игру Угадай Число");
int secretNumber = new Random().Next(1,11);
int attempt = 5;
bool win = false;
while(attempt > 1) {
    Console.WriteLine("Введите число от 1 до 10");
    int userNumber = int.Parse(Console.ReadLine()); 
    Console.WriteLine(userNumber);
    if (secretNumber > userNumber) 
    {
        Console.WriteLine("Секретное число больше");
        attempt--;
    } else {
        if (secretNumber < userNumber) 
        {
            Console.WriteLine("Секретное число меньше");
            attempt--;
        } else {
            Console.WriteLine("Мы угадали");
            win = true;
            break;
        }
    }
}
if(win) {
    Console.WriteLine("Вы выиграли, увидимся через неделю");
    Console.WriteLine("Осталось попыток: " + (attempt - 1));
} else {
    Console.WriteLine("Вы проиграли, секретное число было " + secretNumber);
    Console.WriteLine("Попробуйте еще раз");
}