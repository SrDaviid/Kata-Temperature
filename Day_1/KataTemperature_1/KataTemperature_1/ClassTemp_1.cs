using System;

namespace KataTemperature_1
{
    public enum TemperatureScale { Kelvin, Celsius, Farenheit };
    public class ClassTemp_1
    {
        private TemperatureScale temperatureScale;
        private double value;

        public ClassTemp_1(double val, TemperatureScale scale)
        {
            temperatureScale = scale;
            value = val;
        }


        public double ToFarenheit()
        {
            
            double result = 0;
            if (temperatureScale == TemperatureScale.Kelvin)
            {
                // F = 1.8 x (k - 273.15) + 32
                result = ((value - 273.15) * 1.8) + 32;
                temperatureScale = TemperatureScale.Kelvin;
            }
            else if (temperatureScale == TemperatureScale.Celsius)
            {
                // (C x 1.8) + 32 = F
                result = ((value * 1.8) + 32);
                temperatureScale = TemperatureScale.Celsius;
            }
            else
            {
                result = value;
            }
            value = result;
            return value;
        }


        public double ToCelsius()
        {
            double result = 0;
            if(temperatureScale == TemperatureScale.Kelvin)
            {
                // C = (K - 273.16)
                result = value - 273.16;
                temperatureScale = TemperatureScale.Kelvin;
            }
            else if (temperatureScale == TemperatureScale.Farenheit)
            {
                //C = (F - 32) / 1.8
                result = ((value - 32) / 1.8);
                temperatureScale = TemperatureScale.Farenheit;
            }
            else
            {
                result= value;
            }
            value = result;
            return result;
        }

       public double Kelvin()
        {
            double result = 0;
            return result;
        }
    }
}
