using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.EventTets
{
    class Increment2
    {
        public event EventHandler CountedADozen; //使用系统定义的EventHandler委托

        public void DoCount()
        {
            for (int i = 1 ; i < 100; i++)
            {
                CountedADozen(this, null);
            }
        }
    }

    class Dozens2
    {
        public int DozensCount { get; private set; }
        
        public Dozens2( Increment2 increment2 )
        {
            DozensCount = 0;
            increment2.CountedADozen += IncrementDozensCount;
        }

        void IncrementDozensCount( object source , EventArgs e )
        {
            DozensCount++;
        }
    }
}
