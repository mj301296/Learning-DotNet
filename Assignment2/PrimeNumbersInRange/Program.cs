static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();
    for (int i = Math.Max(2, startNum); i <= endNum; i++)
    {
        bool isPrime = true;
        for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0) { isPrime = false; break; }
        }
        if (isPrime) primes.Add(i);
    }
    return primes.ToArray();
    
}

FindPrimesInRange(2,10);