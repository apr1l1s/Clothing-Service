using Clothing_Service.MVVM.Commands;
using Clothing_Service.MVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clothing_Service.MVVM.ViewModel
{
    class HomeViewModel: ViewModelBase
    {
        public string name => "Вещевая служба";
        public ICommand NavigateLoginCommand { get; }
        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(
                navigationStore,
                () => new LoginViewModel(navigationStore)
            );
        }



    }
}
