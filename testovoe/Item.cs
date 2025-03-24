using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace testovoe
{
    public class Item : INotifyPropertyChanged
    {
        private string name;
        private double xCoordinate;
        private double yCoordinate;
        private double width;
        private double height;
        private bool isDefect;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public double XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; OnPropertyChanged("XCoordinate"); }
        }

        public double YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; OnPropertyChanged("YCoordinate"); }
        }

        public double Width
        {
            get { return width; }
            set { width = value; OnPropertyChanged("Width"); }
        }

        public double Height
        {
            get { return height; }
            set { height = value; OnPropertyChanged("Height"); }
        }

        public bool IsDefect
        {
            get { return isDefect; }
            set { isDefect = value; OnPropertyChanged("IsDefect"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
