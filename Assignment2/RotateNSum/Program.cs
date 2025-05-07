int[] input = { 1, 2, 3, 4, 5 };
int k = 3;
int[] sum = new int[input.Length];
int[] temp = new int[input.Length];
Array.Copy(input, temp, input.Length);
for (int r = 0; r < k; r++)
{
    int last = temp[temp.Length - 1];
    for (int i = temp.Length - 1; i > 0; i--)
        temp[i] = temp[i - 1];
    temp[0] = last;
    for (int i = 0; i < temp.Length; i++)
        sum[i] += temp[i];
}
Console.WriteLine("Sum: " + string.Join(", ", sum));