using Observer.Event;
using Observer.IObserver;
using Observer.TraditionalObs;
using System;

namespace Observer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //EventKeyWord();

            //TraditionalObserver();

            // Monitor a stock ticker, when particular events occur, react
            var st = new IObserver.StockTicker();

            GoogleMonitor gf = new GoogleMonitor();
            MicrosoftMonitor mf = new MicrosoftMonitor();

            using (st.Subscribe(gf))
            using (st.Subscribe(mf))
            {
                // Load the Sample Stock Data
                foreach (var s in SampleData.getNext())
                    st.Stock = s;
            }
        }

        private static void TraditionalObserver()
        {
            var subj = new TraditionalObs.StockTicker();
            GoogleObserver gobs = new GoogleObserver(subj);
            MicrosoftObserver mobs = new MicrosoftObserver(subj);

            foreach (var s in SampleData.getNext())
                subj.Stock = s;
        }

        private static void EventKeyWord()
        {
            var person = new Person();

            person.FallsIll += CallDoctor;

            person.CatchACold();
        }

        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
    }
}
