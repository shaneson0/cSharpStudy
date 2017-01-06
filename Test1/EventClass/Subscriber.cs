using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.EventClass
{
    class Subscriber
    {

        public Subscriber( Publisher publisher  )
        {
            publisher.Lisener += Output0;
            publisher.Lisener += Output1;
            publisher.Lisener += Output2;
            publisher.Lisener += Output3;

        }

        public void Output0(object source , IncrementerData args)
        {
            Console.WriteLine("事件0: 开始接受事件响应..");
        }

        //事件1，向控制台输出特定的数字和name
        public void Output1(object source, IncrementerData args)
        {
            Console.WriteLine("事件1： Console output ..data is {0} , name is {1}", args.Data, args.name);
        }

        //事件2,向控制台输出一个"Hello Event"
        public void Output2(object source, IncrementerData args)
        {
            Console.WriteLine("事件2： Hello Event");
        }

        //事件3，向控制台s输出,output3 ..
        public void Output3(object source, IncrementerData args)
        {
            Console.WriteLine("事件3： output3 .. test , hello !");
        }
    }
}
