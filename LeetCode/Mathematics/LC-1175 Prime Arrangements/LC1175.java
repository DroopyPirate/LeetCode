class LC1175 {

    private static final int MOD = 1000000007;

    public static int numPrimeArrangements(int n) {
        long noOfPrimes = countPrimes(n);
        long noOfNonPrimes = n - noOfPrimes;
        return (int) ((factorial(noOfPrimes) * factorial(noOfNonPrimes)) % MOD);
    }

    public static long factorial(long n) {
        long result = 1;
        for (long i = 2; i <= n; i++) {
            result = (result * i) % MOD;
        }
        return result;
    }

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

        for(int i = 2; i<=n; i++){
            if(prime[i] == true){
                primeCount++;
            }
        }

        return primeCount;
    }

    public static void main(String[] args){
        System.out.println(numPrimeArrangements(5));
        System.out.println(numPrimeArrangements(100));
        System.out.println(numPrimeArrangements(2));
    }
}