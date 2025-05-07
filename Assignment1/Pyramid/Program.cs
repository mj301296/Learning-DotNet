int lines = 5;
for (int i = 1; i <= lines; i++)
{
    // print spaces
    for (int j = 1; j <= lines - i; j++)
        Console.Write(" ");

    // print stars
    for (int k = 1; k <= (2 * i - 1); k++)
        Console.Write("*");

    Console.WriteLine();
}