using System.Windows.Input;

namespace OSEmulator.ViewModel {
    public class MainWindow : BaseViewModel {
        public MainWindow() {
            UpdateViewCommand = new Commands.UpdateViewCommand(this);
            LoginConfirmCommand = new Commands.LoginConfirmCommand(this);
        }
        public ICommand UpdateViewCommand { get; set; }
        public ICommand LoginConfirmCommand { get; set; }

        private BaseViewModel _selectedView = new AuthenticationUI();
        public BaseViewModel SelectedView {
            get { return _selectedView; }
            set { 
                _selectedView = value;
                OnPropertyChanged(nameof(SelectedView));
            }
        }

    }
}
