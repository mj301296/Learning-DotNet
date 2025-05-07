DateTime birthDate = new DateTime(2000, 1, 1);
TimeSpan age = DateTime.Now - birthDate;
int daysOld = (int)age.TotalDays;

Console.WriteLine($"You are {daysOld} days old.");
int next = 10000 - (daysOld % 10000);
DateTime nextAnniversary = DateTime.Now.AddDays(next);
Console.WriteLine($"Next 10,000 day anniversary: {nextAnniversary.ToShortDateString()}");