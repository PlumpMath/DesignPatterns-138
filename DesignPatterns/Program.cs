using DesignPatterns.BehaviorDesign;
using DesignPatterns.ObserverDesign;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BehaviorDesignTest();
            ObserverDesignTest();

            #region Commented Code

            //Doer doer = new Doer();

            //ConcurrentDictionary<int, int> cc = new ConcurrentDictionary<int, int>();
            //Dictionary<int, int> nm = new Dictionary<int, int>();
            ////nm.TryGetValue()
            ////cc.TryGetValue
            ////Maybe
            //UserInterface rr = new UserInterface();
            //doer.NotiLog += rr.Doer_NotiLog1;

            //doer.DoSomeWork("data"); 
            #endregion
            Console.ReadKey();
        }

        #region Observer Design Test
        private static void ObserverDesignTest()
        {
            Console.WriteLine("Observer Design Test Start");
            WeatherData wd = new WeatherData();

            CurentConditionsDisplay cc = new CurentConditionsDisplay(wd);

            wd.SetMeasurements(10, 12, 11);


            Console.WriteLine("Observer Design Test End");
        }
        #endregion

        #region Behavior Design Test
        private static void BehaviorDesignTest()
        {
            Console.WriteLine("Behavior Design Test Start");
            Duck duck = new MallardDuck();
            DuckOperations(duck);

            Console.WriteLine("Behavior Design Test End");
        }

        private static void DuckOperations(Duck duck)
        {
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();
            duck.Swim();
        }
        #endregion
    }
    class UserInterface
    {

        public void Doer_NotiLog1(object sender, string e)
        {
            Console.WriteLine("Doer_NotiLog");
        }

    }
    public class asdf : IObserver<Int16>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(short value)
        {
            throw new NotImplementedException();
        }
    }
    public class abc : IObservable<Int16>
    {
        public IDisposable Subscribe(IObserver<short> observer)
        {
            throw new NotImplementedException();
        }
    }
    class Doer
    {
        //public event delegate NotifySo;


        public event EventHandler<string> NotiLog;
        public event EventHandler<string> NotiLog1;

        //private void Notify()
        //{
        //    if(NotiLog != null)
        //    {
        //    }

        //   Console.WriteLine("Notify");
        //}
        //private void Notify1()
        //{
        //    Console.WriteLine("Notify1");
        //}

        public void DoSomeWork(string data)
        {
            Console.WriteLine("Write");
            if (NotiLog != null)
            {
                this.NotiLog(this, data);
            }

        }
        public void DoMore(string data)
        {
            Console.WriteLine("Write");

            if (NotiLog1 != null)
            {
                this.NotiLog1(this, data);
            }

        }
    }
}
