using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return 5.0 / 9.0 * (fahrenheit - 32.0);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return 9.0 / 5.0 * celsius + 32.0;
        }
    }
}
