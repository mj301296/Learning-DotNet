int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copy = new int[original.Length];
for (int i = 0; i < original.Length; i++)
    copy[i] = original[i];
Console.WriteLine("Original: " + string.Join(", ", original));
Console.WriteLine("Copy:     " + string.Join(", ", copy));