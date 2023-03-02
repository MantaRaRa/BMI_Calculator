using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class HeightWeight
    {
        public double Height;
        public double Weight;

        public void AddHeight(double feet, double inches)
        {
            Height = feet * 12 + inches;
        }

        public double CalculateBMI()
        {

            //BMI = (Weight in pounds / (Height in inches x Height in inches )) x 703
            //PEMDAS

            var BMI_Calculator = (Weight / Math.Pow(Height, 2)) * 703;

            return BMI_Calculator;


        }

    }
}
