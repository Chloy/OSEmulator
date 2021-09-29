using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OSEmulator.Commands {
    class UpdateViewCommand : ICommand {

        private ViewModel.MainWindow mainViewModel;

        public UpdateViewCommand(ViewModel.MainWindow mainWindow) {
            mainViewModel = mainWindow;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter) {
            if(parameter.ToString() == "Admin") {
                mainViewModel.SelectedView = new ViewModel.AdministratorUI();
            }
            else if(parameter.ToString() == "User") {
                mainViewModel.SelectedView = new ViewModel.CommonUserUI();
            }
        }
    }
}
