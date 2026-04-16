using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName) {  UserName = userName; }

        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
        public void Update(string availability)
        {
            Console.WriteLine("Hello " + UserName + ", pruct is now " + availability+" on Amazon");
        }

    }
}
