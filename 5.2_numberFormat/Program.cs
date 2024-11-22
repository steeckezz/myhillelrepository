while (true)
{
    Console.WriteLine("Enter any number");
    string input = Console.ReadLine();
    if (input == "")
    {
        input = null;
    }
    try
    {
        decimal decimalNum = decimal.Parse(input);
        double doubleNum = double.Parse(input);
        float floatNum = float.Parse(input);
        ulong ulongNum = ulong.Parse(input);
        long longNum = long.Parse(input);
        uint uintNum = uint.Parse(input);
        int integerNum = int.Parse(input);
        ushort ushortNum = ushort.Parse(input);
        short shortNum = short.Parse(input);
        sbyte sbyteNum = sbyte.Parse(input);
        byte byteNum = byte.Parse(input);
    }
    catch (FormatException)
    {
        Console.WriteLine("You entered not a number");
    }
    catch (OverflowException)
    {
        Console.WriteLine("You entered a too large number");
    }
    catch(ArgumentNullException)
    {
        Console.WriteLine("You entered nothing");
    }
}