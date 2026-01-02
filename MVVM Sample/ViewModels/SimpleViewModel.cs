using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Sample.ViewModels
{
    public class SimpleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _name;

        public String? Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(Greeting));
                }
            }

        }

        public String? Greeting
        {
            get
            {
                if(string.IsNullOrEmpty(Name))
                {
                    return "Hello, World from Avalonia Samples";
                }
                else
                {
                    return $"Hello, {Name}!";
                }
            }
        }

        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
