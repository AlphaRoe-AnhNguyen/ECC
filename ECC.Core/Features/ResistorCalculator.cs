using ECC.Core.Enums;
using ECC.Core.Interfaces;
using System;

namespace ECC.Core.Features
{
    public class ResistorCalculator : IOhmValueCalculator
    {
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor)
        {
            double a = (double)(ColorEnum)Enum.Parse(typeof(ColorEnum), bandAColor);
            double b = (double)(ColorEnum)Enum.Parse(typeof(ColorEnum), bandBColor);
            double c = (double)(ColorEnum)Enum.Parse(typeof(ColorEnum), bandCColor);

            return (int)((a == 10D ? 0 : a) * Math.Pow(10, (c == 10D ? 0 : c) + 1) + (b == 10D ? 0 : b) * Math.Pow(10, (c == 10D ? 0 : c)));
        }


        public Tuple<double, double> RealCalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor = null)
        {
            double min, max, percent;
            
            double a = (double)(ColorEnum)Enum.Parse(typeof(ColorEnum), bandAColor);
            double b = (double)(ColorEnum)Enum.Parse(typeof(ColorEnum), bandBColor);
            double c = (double)(ColorEnum)Enum.Parse(typeof(ColorEnum), bandCColor);
            var mean = (double)((a == 10D ? 0 : a) * Math.Pow(10, (c == 10D ? 0 : c) + 1) + (b == 10D ? 0 : b) * Math.Pow(10, (c == 10D ? 0 : c)));

            switch (bandDColor)
            {
                case "Gold":
                    percent = 0.05;
                    break;
                case "Silver":
                    percent = 0.1;
                    break;
                default:
                    percent = 0.2;
                    break;
            }

            min = (double)(mean - (mean * percent));
            max = (double)(mean + (mean * percent));

            var rohm = Tuple.Create(min, max);

            return rohm;
        }
    }
}

