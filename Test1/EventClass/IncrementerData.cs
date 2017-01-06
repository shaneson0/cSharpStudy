using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.EventClass
{
    public class IncrementerData : EventArgs 
    {
        public int Data { get; set;}
        public string name { get; set; }

        public IncrementerData( int Data , string name )
        {
            this.Data = Data;
            this.name = name;
        }

    }
}
