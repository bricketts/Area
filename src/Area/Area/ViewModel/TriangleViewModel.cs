using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Area
{
    class TriangleViewModel : INotifyPropertyChanged
    {
        #region Triangle Model

        Triangle _triModel;
        public Triangle TriModel
        {
            get { return _triModel;  }
            set
            {
                _triModel = value;
                OnPropertyChanged();
            }
        }

        public TriangleViewModel()
        {
            TriModel = new Triangle(10, 10);
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}