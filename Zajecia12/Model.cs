using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Zajecia12
{
    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _zoom = 30;

        public int Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Zoom"));
            }
        }
    }
}
