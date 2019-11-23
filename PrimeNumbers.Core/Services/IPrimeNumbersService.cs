namespace PrimeNumbers.Core.Services
{
    public interface IPrimeNumbersService
    {
        bool GetPrimeNumber(int n);

        string CalculatePrimeNumbers(int n, string Primes);
    }
}
