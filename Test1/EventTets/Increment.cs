using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.EventTets
{
    delegate void Handler() ; //声明一个没有返回值，没有参数的委托

    class Increment
    {
        public event Handler CountedADozen;    

        public void DoCount()
        {
            for (int i = 1; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                    CountedADozen();
        }
            
    }

    class Dozens
    {
        public int DozensCount {  get; private set; }

        public Dozens( Increment increment )
        {
            DozensCount = 0;
            increment.CountedADozen += IncrementDozensCount; 
        }

        void IncrementDozensCount()
        {
            DozensCount++;
        }
    }

    
}
