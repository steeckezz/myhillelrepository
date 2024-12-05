//Task 1

//Console.WriteLine("Enter the number of workers");
//var strnum = Console.ReadLine();
//int workersAmount;
//if (int.TryParse(strnum, out workersAmount))
//{
//    int total = 0;
//    for (int i = 0; i < workersAmount; i++)
//    {
//        Console.WriteLine("Enter the salary of one of the employees");
//        var strsalary = Console.ReadLine();
//        int salary;
//        if (int.TryParse(strsalary, out salary))
//        {
//            total += salary;
//        }
//        else
//        {
//            Console.WriteLine("An invalid enter");
//        }
//    }
//    double result = total / workersAmount;
//    Console.WriteLine($"Average salary of workers: {result}");
//}
//else
//{
//    Console.WriteLine("An invalid enter");
//}

//Task 2

//Console.WriteLine("Enter the rows amount");
//var strrowsnum = Console.ReadLine();
//var rowsAmount = int.Parse(strrowsnum);

//for (int i = 1; i <= rowsAmount; i++)
//{
//    for (int j = 0; j < i; j++)
//        Console.Write("*");
//    Console.WriteLine();
//}

//Task 3

//using System;

//Console.WriteLine("Enter the number");
//var input = Console.ReadLine();
//var number = int.Parse(input);


//for (int i = 0; i <= number; i++)
//{
//    int j = 2;
//    while(j <= Math.Sqrt(i))
//    {
//        if (i % j != 0)
//        {
//            Console.WriteLine(i);
//        }
//        j++;
//    }
//}


//Task 4

//Console.WriteLine("Enter the password");
//var input = Console.ReadLine();
//var password = int.Parse(input);



//Task 5

//Console.WriteLine("Enter the number");
//var input = Console.ReadLine();
//var number = int.Parse(input);
//ulong j = 0;
//ulong k = 1;
//ulong l;
//for (int i = 0; i < number; i++)
//{
//    l = j + k;
//    Console.WriteLine(l);
//    j = k;
//    k = l;
//}


//Task 6

//Console.WriteLine("Enter the daily number of working hours");
//var input = Console.ReadLine();
//var workTime = int.Parse(input);

//Console.WriteLine("Enter the hourly rate");
//var input2 = Console.ReadLine();
//var hourlyRate = double.Parse(input2);

//Console.WriteLine($"Your daily fee is {workTime * hourlyRate}");


//Task 7

//Console.WriteLine("Enter the number");
//var input = Console.ReadLine();
//var number = int.Parse(input);

//Console.WriteLine($"multiplication table for {number}:");
//for (int i = 1; i <= 10; i++)
//{
//    int number2 = number * i;
//    Console.WriteLine(number2);
//}


//Task 8

//Console.WriteLine("Enter the number");
//var input = Console.ReadLine();
//var number = int.Parse(input);

//for (int i = 2; i < Math.Sqrt(number); i++)
//{
//    if ()
//}