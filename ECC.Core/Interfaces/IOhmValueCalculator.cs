﻿using System;

namespace ECC.Core.Interfaces
{
    public interface IOhmValueCalculator
    {
        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor);

        /// <summary>
        /// Estimate the real Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        Tuple<double, double> RealCalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }
}
