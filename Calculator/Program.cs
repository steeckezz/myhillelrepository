Console.WriteLine("Калькулятор");

Console.WriteLine("Введіть перше ціле число");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введіть друге ціле число");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введіть одну з цих математичних дій: 1.+ 2.- 3.* 4./");
int operation = Convert.ToInt32(Console.ReadLine());

switch (operation)
{
    case 1:
        int result1 = firstNum + secondNum;
        Console.WriteLine($"В суммі {firstNum} і {secondNum} дають {result1}");
        break;
    case 2:
        int result2 = firstNum - secondNum;
        Console.WriteLine($"Різниця {secondNum} від {firstNum} буде {result2}");
        break;
    case 3:
        int result3 = firstNum * secondNum;
        Console.WriteLine($"Добутком {firstNum} і {secondNum} є {result3}");
        break;
    case 4:
        int result4 = firstNum / secondNum;
        Console.WriteLine($"При діленні {firstNum} на {secondNum} результат {result4}");
        break;
    default:
        Console.WriteLine("В функціоналі є лише 4 дії");
        break;
}