
Console.CursorVisible = false;
char[,] map = {{'#', '#', '#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#', ' ', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ','x',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', '#', '#','#','#',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', '#', ' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ',' ',' ',' ','x',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ',' ',' ','x','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', '#', '#','#','#','#','#','#','#','#','#','#','#','#','#'}
};

int x = 7;
int y = 7;
char[] bag = new char[1];
bool open = true;

while (open)
{
    Console.SetCursorPosition(0, 20);
    Console.Write("Сумка: ");
    for (int i = 0; i < bag.Length; i++)
    {
        Console.Write(bag[i] + " ");
    }

    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(map[i, j]);
        }
        Console.WriteLine();
    }
    Console.SetCursorPosition(y, x);
    Console.Write('O');
    ConsoleKeyInfo charKey = Console.ReadKey();
    switch (charKey.Key)
    {
        case ConsoleKey.UpArrow:
            if (map[x - 1, y] != '#') x--;
            break;
        case ConsoleKey.DownArrow:
            if (map[x + 1, y] != '#') x++;
            break;
        case ConsoleKey.LeftArrow:
            if (map[x, y - 1] != '#') y--;
            break;
        case ConsoleKey.RightArrow:
            if (map[x, y + 1] != '#') y++;
            break;
        case ConsoleKey.Escape:
            open = false;
            break;
    }

    if (map[x, y] == 'x')
    {
        map[x, y] = 'o';
        char[] tempbag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempbag[i] = bag[i];
        }
        tempbag[tempbag.Length - 1] = 'x';
        bag = tempbag;
    }
    Console.ReadKey();
    Console.Clear();
}






