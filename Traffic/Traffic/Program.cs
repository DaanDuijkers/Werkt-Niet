using System;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            Console.WriteLine(trafficLight.getCurrentColor());
            trafficLight.NextState();
            Console.WriteLine(trafficLight.getCurrentColor());
            trafficLight.NextState();
            Console.WriteLine(trafficLight.getCurrentColor());
            trafficLight.NextState();
            Console.WriteLine(trafficLight.getCurrentColor());

            Console.ReadKey();
        }
    }
}
