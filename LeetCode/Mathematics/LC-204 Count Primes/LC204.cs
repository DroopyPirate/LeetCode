// using Sieve of Eratosthenes
// https://www.geeksforgeeks.org/sieve-of-eratosthenes/

using System;

class LC204 {
    public static int CountPrimes(int n) {
        bool[] prime = new bool[n + 1];
        int primeCount = 0;

        for (int i = 0; i <= n; i++)
            prime[i] = true;

        for (int i = 2; i * i <= n; i++) {
            if (prime[i]) {
                for (int j = i * i; j <= n; j += i) {
                    prime[j] = false;
                }
            }
        }

        for (int i = 2; i < n; i++) {
            if (prime[i]) {
                primeCount++;
            }
        }

        return primeCount;
    }

    public static void Main(string[] args) {
        Console.WriteLine(CountPrimes(10)); // Output: 4
        Console.WriteLine(CountPrimes(0));  // Output: 0
        Console.WriteLine(CountPrimes(1));  // Output: 0
        Console.WriteLine(CountPrimes(2));  // Output: 0
    }
}