using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Area
{
    class Triangle : INotifyPropertyChanged
    {
        private double _base;
        public double Base
        {
            get { return _base; }
            set
            {
                _base = value;
                OnPropertyChanged();
                OnPropertyChanged("Area");
            }
        }

        private double _height;
        public double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged();
                OnPropertyChanged("Area");
            }
        }

        private double _area;
        public double Area
        {
            get { return _area; }
            set
            {
                Area = .5 * (Base * Height);
                OnPropertyChanged();
                OnPropertyChanged("Area");
            }
        }

        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
            //Area = .5 * ( Base * Height);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
