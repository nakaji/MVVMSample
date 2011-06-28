using System;

namespace MVVMSample
{
    public class BmiViewModel
    {
        public double Height { get; set; }
        
        public double Weight { get; set; }

        public double Bmi
        {
            get
            {
                return Math.Truncate(Weight / Math.Pow((Height / 100), 2) * 100) / 100;
            }
        }
    }
}
