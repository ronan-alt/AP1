using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AP1.Services;
using System.Threading.Tasks;

namespace AP1.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _errorMessage = string.Empty;
        private bool _hasError;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set { _errorMessage = value; OnPropertyChanged(); }
        }

        public bool HasError
        {
            get => _hasError;
            set { _hasError = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            HasError = false;
            ErrorMessage = string.Empty;

            // Exemple d'appel à un service d'API (à adapter selon votre backend)
            using var api = new Apis();
            var loginData = new { Username, Password };
            var result = await api.PostOneAsync("auth/login", loginData);

            if (result)
            {
                // Navigation ou traitement après succès
            }
            else
            {
                HasError = true;
                ErrorMessage = "Identifiant ou mot de passe incorrect.";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}