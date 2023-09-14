using Clothing_Service.MVVM.Stores;
using Clothing_Service.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Service.MVVM.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;
        private readonly bool _param;
        public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel, bool param = true)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _param = param;
        }
        public override void Execute(object parameter)
        {
            if (_param)
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
