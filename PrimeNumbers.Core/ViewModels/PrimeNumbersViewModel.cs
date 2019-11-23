using MvvmCross.Commands;
using MvvmCross.ViewModels;
using PrimeNumbers.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrimeNumbers.Core.ViewModels
{
    public class PrimeNumbersViewModel : MvxViewModel
    {
        private readonly IPrimeNumbersService _primeNumbersService;
        private int _n;
        private string _result;
        private string _primes;
        private MvxCommand _calculateCommand;

        public PrimeNumbersViewModel(IPrimeNumbersService primeNumbersService)
        {
            _primeNumbersService = primeNumbersService;
        }

        public int N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public string Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public string Primes
        {
            get => _primes;
            set => SetProperty(ref _primes, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            N = 0;
            Calculate();
        }

        private void Calculate()
        {
            Result = _primeNumbersService.CalculatePrimeNumbers(N, Primes);
        }
    }
}
