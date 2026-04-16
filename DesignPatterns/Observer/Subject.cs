using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class Subject : ISubject
    {
        private List<IObserver> observers=new List<IObserver>();
        private string Productname { get; set; }
        private int ProductPrice {  get; set; }
        private string Availability { get; set; }

        public Subject(string productName, int productPrice,string availability)
        {
            Productname = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string GetAvailability()
        {
            return Availability;
        }
        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObserver();
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("observer Added: " + ((Observer)observer).UserName);
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
            observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            Console.WriteLine("Product name: "
                + Productname + ", product price: "
                + ProductPrice + "is available.So,Notify all registered Users");
            Console.WriteLine();

            foreach(IObserver observer in observers)
                observer.Update(Availability);
        }
    }
}
    