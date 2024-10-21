using System;

class LC1175
{
    private const int MOD = 1000000007;

    public static int NumPrimeArrangements(int n)
    {
        long noOfPrimes = CountPrimes(n);
        long noOfNonPrimes = n - noOfPrimes;
        return (int)((Factorial(noOfPrimes) * Factorial(noOfNonPrimes)) % MOD);
    }

    public static long Factorial(long n)
    {
        long result = 1;
        for (long i = 2; i <= n; i++)
        {
            result = (result * i) % MOD;
        }
        return result;
    }

    public static int CountPrimes(int n)
    {
        bool[] prime = new bool[n + 1];
        int primeCount = 0;
        for (int i = 0; i <= n; i++)
            prime[i] = true;

        for (int i = 2; i * i <= n; i++)
        {
            if (prime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    prime[j] = false;
                }
            }
        }

        for (int i = 2; i <= n; i++)
        {
            if (prime[i])
            {
                primeCount++;
            }
        }

        return primeCount;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(NumPrimeArrangements(5));    // Output: 12
        Console.WriteLine(NumPrimeArrangements(100));  // Output: 682289015
        Console.WriteLine(NumPrimeArrangements(2));    // Output: 1
    }
}
