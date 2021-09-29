using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OSEmulator.Commands {
    class LoginConfirmCommand : ICommand {

        private ViewModel.MainWindow mainWindow;

        public LoginConfirmCommand(ViewModel.MainWindow mainWindow) {
            this.mainWindow = mainWindow;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            if(parameter.ToString() == "Admin") {
                mainWindow.SelectedView = new ViewModel.AdministratorUI();
            }
            else if(parameter.ToString() == "User") {
                mainWindow.SelectedView = new ViewModel.CommonUserUI();
            }
        }
    }
}
