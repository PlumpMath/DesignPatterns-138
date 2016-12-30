using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverDesign
{
    public class WeatherEventArgs : EventArgs
    {
        public double Temp { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
    }
}
