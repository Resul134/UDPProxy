using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class SensorData
    {
        public int Id { get; set; }
        public string SensorName { get; set; }
        public int Temperature { get; set; }
        public int CO2 { get; set; }

        public SensorData(int id, string sensorName, int temperature, int co2)
        {
            Id = id;
            SensorName = sensorName;
            Temperature = temperature;
            CO2 = co2;
        }








    }
}
