using System;
namespace AlarmSystem

//code made some changes from here
{
    //fields
    //private property Security As implements End Property;


    public class FireSensor : ISensor {

        private string location = "Main lobby";
        private string type = "Fire Sensor";
        private int battery = 100;


        public bool IsTriggered { get; set; }
        Random random = new Random();

}

        

        public FireSensor()
        {
            IsTriggered = false;            
        }


        public string GetLocation()
        {
            return String.Empty; // convention is to use the .NET class for properties/methods/constants
        }

        public string GetSensorType()
        {
            return String.Empty;
        }

        public double GetBatteryPercentage()
        {
            return -1.0;
        }
    }

    public class SmokeSensor : ISensor
    {
        public bool IsTriggered { get; set; }

        public SmokeSensor()
        {
            IsTriggered = false;
        }

        public string GetLocation()
        {
            return String.Empty;
        }

        public string GetSensorType()
        {
            return String.Empty;
        }

        public double GetBatteryPercentage()
        {
            return -1.0;
        }
    }
}
