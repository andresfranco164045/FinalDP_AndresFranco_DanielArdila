namespace PrimeNumbers.Core.Services
{
    class PrimeNumbersService : IPrimeNumbersService
    {
        public bool GetPrimeNumber(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public string CalculatePrimeNumbers(int n, string Primes)
        {
            int conPri = 0, i = 1;
            Primes = "";
            while (conPri < n)
            {
                if (GetPrimeNumber(i))
                {
                    Primes += string.Format("{0:N0}\t", i);
                    conPri++;
                }
                i++;
            }
            return Primes;
        }
    }
}
