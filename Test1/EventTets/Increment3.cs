using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.EventTets
{
    public class IncrementEventArgs3 : EventArgs
    {
        public int IterationCount { get; set; }

    }

    class Increment3
    {
        public event EventHandler<IncrementEventArgs3> CountedADozen;

        //自定义类对象
        public void DoCount()
        {
            IncrementEventArgs3 args = new IncrementEventArgs3();
            for (int i = 1  ; i < 100; i++)
            {
                if( i % 12 == 0 && CountedADozen != null )
                {
                    args.IterationCount = i;
                    CountedADozen(this, args);
                }
            }
        }

    }

    class Dozen3
    {
        public int DozensCount { get; set; }

        public Dozen3(Increment3 increment3 )
        {
            DozensCount = 0;
            increment3.CountedADozen += this.IncrementDozensCount;
        }

        void IncrementDozensCount( object source , IncrementEventArgs3 e )
        {
            Console.WriteLine("Incremented at iteration {0} in {1} ", e.IterationCount, source.ToString());
            DozensCount++;
        }

    }
}
