using System;

namespace KataTemperature_2
{
        public enum Scale { Kelvin, Celsius, Farenheit}
        public class ClassTemperatures
        {
            private double temperature;
            private Scale scale;
            public ClassTemperatures(double temp, Scale _scale)
            {
                temperature = temp;
                scale = _scale;
            }

            public double ToFarenheit()
            {
                switch(scale)
                {
                    case Scale.Kelvin:
                        // F = 1.8 x (k - 273.15) + 32
                        temperature = System.Math.Round((temperature - 273.15)*1.8 +32, 2);
                        scale = Scale.Kelvin;
                        break;

                    case Scale.Celsius:
                        // (C x 1.8) + 32 = C
                        temperature = System.Math.Round((temperature * 9/5) +32,2);
                        scale = Scale.Celsius;
                        break;

                    case Scale.Farenheit:
                        break;
                    default:
                        break;
                }
                return temperature;
            }
            public double ToKelvin()
            {
                switch(scale)
                {
                    case Scale.Farenheit:
                        // (F - 32) * 5/9 + 273.15
                        temperature = System.Math.Round((temperature - 32) * 5 / 9 + 273.15,2);
                        scale = Scale.Farenheit;
                        break;

                    case Scale.Kelvin:
                        break;

                    case Scale.Celsius:
                        // C + 273.15
                        temperature = System.Math.Round(temperature + 273.15,2);
                        scale =Scale.Celsius;
                        break;

                }
                return temperature;
            }
            
            public double ToCelsius()
            {
                switch(scale)
                {
                    case Scale.Celsius:
                        break;

                    case Scale.Farenheit:
                        //(0 °C × 9/5) + 32 = 32 °F
                        temperature = System.Math.Round((temperature -32) *5/9, 2);
                        scale = Scale.Farenheit;
                        break;

                    case Scale.Kelvin:
                        //0 °C + 273.15 = 273.15 K
                        temperature = System.Math.Round(temperature - 273.15,2);
                        scale = Scale.Kelvin;
                        break;
                }
                return temperature;
            }
        }
}
