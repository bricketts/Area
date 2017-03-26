using System.ComponentModel;

namespace Area
{
    class TriangleViewModel : INotifyPropertyChanged
    {
        #region Triangle
        private double _triHeight;
        private double _triBase;

        public double TriangleHeight
        {
            get { return _triHeight; }
            set
            {
                _triHeight = value;
                NotifyPropertyChanged("TriangleHeight");
                TriangleShape = new Triangle(TriangleHeight, TriangleBase);
            }
        }

        public double TriangleBase
        {
            get { return _triBase; }
            set
            {
                _triBase = value;
                NotifyPropertyChanged("TriangleBase");
                TriangleShape = new Triangle(TriangleHeight, TriangleBase);
            }
        }

        private Shape _triShape;

        public Shape TriangleShape
        {
            get { return _triShape; }
            set
            {
                _triShape = value;
                NotifyPropertyChanged("TriangleShape");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}