
        Console.Write("Enter number of centuries: ");
        int centuries = int.Parse(Console.ReadLine());

        int years = centuries * 100;
        int days = (int)(years * 365);
        long hours = (long)days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        ulong microseconds = (ulong)milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        Console.WriteLine($"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
