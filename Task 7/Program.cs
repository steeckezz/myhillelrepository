using System.Linq;
using System.Runtime.InteropServices;

char[,] gameField = new char[3,3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
var arrayX = new int[9];
var arrayO = new int[9];
var turn = 'X';
string winner = null;
var count = 0;
while (true)
{
    Console.WriteLine();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(" " + gameField[i, j]);
            if (j < 2)
            {
                Console.Write(" |");
            }
        }
        if (i < 2)
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
        }
        else
        {
            Console.WriteLine();
        }
    }
    if (winner != null)
    {
        Console.WriteLine($"Winner is {winner}");
        return;
    }
    var input = 0;
    count++;
    if (count == 10)
    {
        Console.WriteLine("Draw");
        break;
    }
    while (true)
    {
        Console.WriteLine($"\nEnter player {turn} move\n");
        var stringInput = Console.ReadLine();
        input = int.Parse(stringInput);
        if (!arrayX.Concat(arrayO).Contains(input) && input < 10 && input > 0)
        {
            break;
        }
    }
    if (turn == 'X')
    {
        arrayX[input - 1] = input;
    }
    else
    {
        arrayO[input - 1] = input;
    }

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (gameField[i, j] == char.Parse(input.ToString()))
            {
                gameField[i, j] = turn;
            }
        }
    }
    if (turn == 'X')
    {
        turn = 'O';
    }
    else
    {
        turn = 'X';
    }

    var winningCombinations = new int[][]
    {
    new int[] { 1, 2, 3 },
    new int[] { 4, 5, 6 },
    new int[] { 7, 8, 9 },
    new int[] { 1, 5, 9 },
    new int[] { 7, 5, 3 },
    new int[] { 1, 4, 7 },
    new int[] { 2, 5, 8 },
    new int[] { 3, 6, 9 }
    };

    foreach (var winningCombination in winningCombinations)
    {
        if (arrayX.Intersect(winningCombination).Count() == 3)
        {
            winner = "X";
            break;
        }
        else if (arrayO.Intersect(winningCombination).Count() == 3)
        {
            winner = "O";
            break;
        }
    }
}