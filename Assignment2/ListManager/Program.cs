List<string> items = new List<string>();
while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    string input = Console.ReadLine();
    if (input.StartsWith("+")) items.Add(input.Substring(1).Trim());
    else if (input.Equals("--")) items.Clear();
    else if (input.StartsWith("-")) items.Remove(input.Substring(1).Trim());
    Console.WriteLine("List: " + string.Join(", ", items));
}