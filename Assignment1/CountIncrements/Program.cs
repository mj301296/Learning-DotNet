for (int outer = 1; outer <= 4; outer++)
{
    for (int i = 0; i <= 24; i += outer)
    {
        Console.Write(i);
        if (i + outer <= 24) Console.Write(", ");
    }
    Console.WriteLine();
}