using Prism.Mvvm;
using Prism.Navigation;

namespace PrismHotReloadBug.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _helloText = "Hello, Prism MVVM";
        public string HelloText
        {
            get => _helloText;
            set => SetProperty(ref _helloText, value);
        }

        void INavigatedAware.OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        void INavigatedAware.OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
