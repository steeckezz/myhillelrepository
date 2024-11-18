Console.WriteLine("Введіть номер тижня і натисніть Enter, щоб отримати його назву.");
int dayNum = Convert.ToInt32(Console.ReadLine());
switch (dayNum){
    case 1:
        Console.WriteLine("Понеділок");
        break;
    case 2:
        Console.WriteLine("Вівторок");
        break;
    case 3:
        Console.WriteLine("Середа");
        break;
    case 4:
        Console.WriteLine("Четвер");
        break;
    case 5:
        Console.WriteLine("П'ятниця");
        break;
    case 6:
        Console.WriteLine("Субота");
        break;
    case 7:
        Console.WriteLine("Неділя");
        break;
    default:
        Console.WriteLine("Потрібні числа від 1 до 7");
        break;
}