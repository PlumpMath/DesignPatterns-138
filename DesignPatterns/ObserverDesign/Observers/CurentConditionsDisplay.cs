using DesignPatterns.ObserverDesign.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverDesign
{
    public class CurentConditionsDisplay : IDisplay
    {
        WeatherData weatherData;
        private double temp;
        private double humidity;
        private double pressure;

        public CurentConditionsDisplay(WeatherData wd)
        {
            weatherData = wd;
            wd.Notify += WeatherData_Notify;
        }

        private void WeatherData_Notify(object sender, WeatherEventArgs e)
        {
            temp = e.Temp;
            humidity = e.Humidity;
            pressure = e.Pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Condition : Temp => {temp}, Humidity => {humidity}, Pressure => {pressure}");
        }
    }
}
