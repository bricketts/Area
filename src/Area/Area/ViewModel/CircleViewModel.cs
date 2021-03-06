﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class CircleViewModel : INotifyPropertyChanged
    {
        #region Cirlce
        private double _circleRadius;

        public double CircleRadius
        {
            get { return _circleRadius; }
            set
            {
                _circleRadius = value;
                NotifyPropertyChanged("CircleRadius");
                //CircleShape = new Circle(CircleRadius);
            }
        }

        private Shape _circleShape;

        public Shape CircleShape
        {
            get { return _circleShape; }
            set
            {
                _circleShape = value;
                NotifyPropertyChanged("CircleShape");
               
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
