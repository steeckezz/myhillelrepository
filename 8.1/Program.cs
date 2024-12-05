
//int[] array = new int[10];
//int sum = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    var random = new Random();
//    array[i] = random.Next(-10, 10);
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(array[i]);
//    }
//    sum = sum + array[i]; // Якщо треба написати чи є невід'ємною сумма саме виведених чисел то треба просто перенести цю строку в if нагорі
//}
//if (sum >= 0)
//{
//    Console.WriteLine("The sum of the numbers is not negative");
//}
//else
//{
//    Console.WriteLine("The sum of the numbers is negative");
//}




//int[,] tableArray = new int[9, 9];
//for (int i = 0; i < 9; i++)
//{
//    Console.WriteLine();
//    for (int j = 0; j < 9; j++)
//    {
//        tableArray[i, j] = (i + 1) * (j + 1);
//        Console.Write(tableArray[i, j] + " ");
//    }
//}



//int greatestNum = 0;
//int smallestNum = 0;
//int[,] array = new int[5, 5];
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine();
//    for (int j = 0; j < 5; j++)
//    {
//        var random = new Random();
//        array[i, j] = random.Next(-10, 10);
//        Console.Write($"{array[i, j]} ");
//        if (greatestNum <= array[i, j])
//        {
//            greatestNum = array[i, j];
//        }
//        if (smallestNum >= array[i, j])
//        {
//            smallestNum = array[i, j];
//        }
//    }
//}
//Console.WriteLine();
//Console.WriteLine($"The biggest number is {greatestNum}");
//Console.WriteLine($"The smallest number is {smallestNum}");

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if (array[i, j] == greatestNum)
//        {
//            Console.WriteLine($"Index of the biggest number is {i}, {j}");
//        }
//        if (array[i, j] == smallestNum)
//        {
//            Console.WriteLine($"Index of the smallest number is {i}, {j}");
//        }
//    }
//}



//Console.WriteLine("Enter the number of days");
//var input = Console.ReadLine();
//var daysNum = int.Parse(input);

//int day = daysNum % 7;
//Console.WriteLine((Days)day);

//enum Days
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}