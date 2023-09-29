using MyMVVMProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVMProject.ViewModel
{
    public class HelloWorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _helloString;

        public string HelloString
        {
            get
            {
                return _helloString;
            }
            set
            {
                if( _helloString != value )
                {
                    _helloString = value;
                    OnPropertyChanged();
                }
            }
        }



        protected void OnPropertyChanged([CallerMemberName] string nombrePropiedad = "")
        {

            if(nombrePropiedad != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
            }

        }


        public HelloWorldViewModel()
        {
            HelloWorldModel helloWorldModel = new HelloWorldModel();

            _helloString = helloWorldModel.ImportantInfo;

        }


    }
}
