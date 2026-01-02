using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace MVVM_Sample.ViewModels
{
    public class ReactiveViewModel : ReactiveObject
    {
        private string _name;

        public ReactiveViewModel()
        {
            this.WhenAnyValue(o => o.Name)
                .Subscribe(_ => this.RaisePropertyChanged(nameof(Greeting)));
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _name, value);
            }
        }

        public String? Greeting
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return "Hello, World from Avalonia Samples";
                }
                else
                {
                    return $"Hello, {Name}!";
                }
            }
        }
    }
}