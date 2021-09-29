using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OSEmulator.ViewModel {
    public class AuthenticationUI : BaseViewModel {
        public AuthenticationUI(MainWindow mainWindow) {
            LoginConfirm = new Commands.LoginConfirmCommand(mainWindow);
        }
        public ICommand LoginConfirm { get; set; }
    }
}
