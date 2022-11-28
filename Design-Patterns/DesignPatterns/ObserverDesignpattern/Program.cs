using System;
using System.Collections.Generic;

namespace ObserverDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency agency1 = new NewsAgency("Alpha News Agency");
            weatherStation.Attach(agency1);

            NewsAgency agency2 = new NewsAgency("Beta News Agency");
            weatherStation.Attach(agency2);

            weatherStation.Temperatur = 31.2f;
            weatherStation.Temperatur = 21.2f;
            weatherStation.Temperatur = 41.2f;
            weatherStation.Temperatur = 10.2f;

            Console.ReadLine();
        }
    }

    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }

    class WeatherStation: ISubject
    {
        private List<IObserver> _observer;
        public float Temperatur 
        {
            get { return _temperature; }
            set 
            {
                _temperature = value;
                Notify();
            } 
        }
        private float _temperature;

        public WeatherStation()
        {
            _observer = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observer.Add(observer);
        }

        public void Notify()
        {
            _observer.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }

    interface IObserver
    {
        void Update(ISubject subject);
    }

    class NewsAgency: IObserver
    {
        public String AgencyName { get; set; }
        public NewsAgency(string agencyName)
        {
            AgencyName = agencyName;
        }
        
        public void Update(ISubject subject)
        {
            if(subject is WeatherStation weatherStation)
            {
                Console.WriteLine(String.Format("{0} reporting temperature {1} degreee celcius",
                                                 AgencyName,
                                                 weatherStation.Temperatur));
                Console.WriteLine();
            }
        }
    }
}
