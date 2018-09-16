using System.Collections.Generic;

namespace Observer.TraditionalObs
{
    public abstract class AbstractSubject
    {
        List<AbstractObserver> observers = new List<AbstractObserver>();

        public void Register(AbstractObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregster(AbstractObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var obs in observers)
            {
                obs.Update();
            }
        }
    }
}
