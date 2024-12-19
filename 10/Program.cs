//10.1

//Console.WriteLine("Введіть ваше ім'я та прізвище");
//var input = Console.ReadLine();
//var subStrings = input.Split(' ');
//var firstName = subStrings[0];
//var lastName = subStrings[1];
//if (firstName[0] == lastName[0])
//{
//    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
//}
//else
//{
//    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
//}


//10.2

//using System.Text;
//Console.WriteLine("Write the title and press Enter, then type the event");
//while (true)
//{
//    DateTime dateTime = DateTime.Now;
//    var title = Console.ReadLine();
//    var action = Console.ReadLine();
//    Console.WriteLine("---------------------------------");
//    StringBuilder sb = new StringBuilder();
//    sb.Append(dateTime);
//    sb.Append(" - ");
//    sb.Append(title);
//    sb.Append('\n');
//    sb.Append(action);
//    string result = sb.ToString();
//    Console.WriteLine(result);
//    Console.WriteLine("---------------------------------");
//}

//10.3

//string line = "Mercury, Venus, Earth, Mars";
//string output = line.Replace(" ", "");
//Console.WriteLine(output);