int correctNumber = new Random().Next(1, 4); // 1 to 3
Console.Write("Guess a number (1-3): ");
int guessedNumber = int.Parse(Console.ReadLine());

if (guessedNumber < 1 || guessedNumber > 3)
    Console.WriteLine("Out of range!");
else if (guessedNumber < correctNumber)
    Console.WriteLine("Too low!");
else if (guessedNumber > correctNumber)
    Console.WriteLine("Too high!");
else
    Console.WriteLine("Correct!");