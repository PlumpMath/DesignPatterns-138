using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverDesign
{
    public class WeatherData
    {
        public event EventHandler<WeatherEventArgs> Notify;

        private double temp;
        private double humidity;
        private double pressure;

        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }

        private void MeasurementChanged()
        {
            Notify?.Invoke(this, new WeatherEventArgs() { Temp = temp, Humidity = humidity, Pressure = pressure });
        }
    }
}

