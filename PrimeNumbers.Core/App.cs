using MvvmCross.IoC;
using MvvmCross.ViewModels;
using PrimeNumbers.Core.ViewModels;

namespace PrimeNumbers.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<PrimeNumbersViewModel>();
        }
    }
}
