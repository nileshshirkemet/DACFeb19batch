using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp
{
    using System.ComponentModel;
    using System.Windows.Input;

    public class VisitorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private VisitorModel model = new VisitorModel();

        public IEnumerable<Visitor> Visitors => model.ReadVisitors();

        private string nameToRegister;

        public string NameToRegister
        {
            get => nameToRegister;
            set
            {
                nameToRegister = value;
                OnPropertyChanged(nameof(NameToRegister));
            }
        }

        private bool CanExecuteRegister() => nameToRegister?.Length > 0;

        private void ExecuteRegister()
        {
            model.WriteVisitor(nameToRegister);
            OnPropertyChanged(nameof(Visitors));
        }

        class RegisterCommand : ICommand
        {
            internal VisitorViewModel Parent;

            event EventHandler ICommand.CanExecuteChanged
            {
                add
                {
                    CommandManager.RequerySuggested += value;
                }

                remove
                {
                    CommandManager.RequerySuggested -= value;
                }
            }

            bool ICommand.CanExecute(object parameter)
            {
                return Parent.CanExecuteRegister();
            }

            void ICommand.Execute(object parameter)
            {
                Parent.ExecuteRegister();
            }
        }

        public ICommand Register => new RegisterCommand { Parent = this };
    }
}
