using System;
using System.ComponentModel;

namespace MVVMSample
{
    public class BmiViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public double Height { get; set; }

        public double Weight { get; set; }

        private double _bmi;
        public double Bmi
        {
            get { return _bmi; }

            set
            {
                _bmi = value;
                RaisePropertyChanged("Bmi");
            }
        }

        public void Calc()
        {
            //小数第2位で切り捨て
            Bmi = Math.Truncate((Weight / Math.Pow((Height / 100), 2)) * 100) / 100;
        }
    }
}
