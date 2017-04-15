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
                _rectShape.Height = value;
                NotifyPropertyChanged("RectangleHeight");
            }
        }

        public double RectangleWidth
        {
            get { return _rectWidth; }
            set
            {
                _rectWidth = value;
                _rectShape.Width = value;
                NotifyPropertyChanged("RectangleWidth");
            }
        }

        private Rectangle _rectShape = new Rectangle(0, 0);

        public Rectangle Rectangle
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
