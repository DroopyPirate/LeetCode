

// using Sieve of Eratosthenes
// https://www.geeksforgeeks.org/sieve-of-eratosthenes/


class LC204 {
    public static int countPrimes(int n) {
        boolean[] prime = new boolean[n+1];
        int primeCount = 0;
        for(int i=0; i<=n; i++)
            prime[i] = true;
        
        for(int i=2; i * i <= n; i++){
            if(prime[i] == true){
                for(int j = i * i; j <= n; j += i){
                    prime[j] = false;
                }
            }
        }

        for(int i = 2; i<n; i++){
            if(prime[i] == true){
                primeCount++;
            }
        }

        return primeCount;
    }

    public static void main(String[] args){
        System.out.println(countPrimes(10));
        System.out.println(countPrimes(0));
        System.out.println(countPrimes(1));
        System.out.println(countPrimes(2));
    }
}