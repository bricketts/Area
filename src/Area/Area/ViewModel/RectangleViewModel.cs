using System.ComponentModel;

namespace Area
{
    class RectangleViewModel : INotifyPropertyChanged
    {
        #region Rectangle
        private double _rectHeight;
        private double _rectWidth;

        public double RectangleHeight
        {
            get { return _rectHeight; }
            set
            {
                _rectHeight = value;
                NotifyPropertyChanged("RectangleHeight");
                RectangleShape = new Rectangle(RectangleHeight, RectangleWidth);
            }
        }

        public double RectangleWidth
        {
            get { return _rectWidth; }
            set
            {
                _rectWidth = value;
                NotifyPropertyChanged("RectangleWidth");
                RectangleShape = new Rectangle(RectangleHeight, RectangleWidth);
            }
        }

        private Shape _rectShape;

        public Shape RectangleShape
        {
            get { return _rectShape; }
            set
            {
                _rectShape = value;
                NotifyPropertyChanged("RectangleShape");
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
