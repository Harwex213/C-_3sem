using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace S2_Lab02
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
    
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
    
    public class PlaneSubject : ISubject
    {
        public double Temperature { get; private set; }
        public double Height { get; private set; }
        public double Speed { get; private set; }

        private List<IObserver> _observers = new();
        
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void GetNewData()
        {
            Temperature += new Random().Next(-4, -2);
            Height += new Random().Next(200, 300);
            Speed += new Random().Next(30, 50);
            
            Notify();
        }
    }

    public class OnBoardComputer : IObserver
    {
        public void Update(ISubject subject)
        {
            MessageBox.Show(@"On-Board Computer reacted to the event of Subject.");
        }
    }
    
    public class Chassis : IObserver
    {
        public void Update(ISubject subject)
        {
            MessageBox.Show(@"Chassis reacted to the event of Subject.");
        }
    }
}