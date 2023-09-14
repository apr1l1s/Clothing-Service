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
    class LoginViewModel : ViewModelBase
    {
        public string AppTitleText => "Вещевая служба";
        public string LoginTextBoxText => "Логин";
        public string PasswordTextBoxText => "Пароль";
        public string LoginButtonText => "Войти";
        public ICommand Login { get; }
        public LoginViewModel(NavigationStore navigationStore)
        {

            Login = new NavigateCommand<HomeViewModel>(
                navigationStore,
                () => new HomeViewModel(navigationStore), 
                CheckUser());
        }
        private bool CheckUser()
        {
            //Проверка наличие пользователя
            return true;
        }
    }
}
