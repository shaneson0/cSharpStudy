using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.EventClass
{


    //订阅者有三个事件，分别为向控制台输出，向文本1输出，向文本2输出
    class Publisher
    {
        public event EventHandler<IncrementerData> Lisener;

        public void Publish( IncrementerData data )
        {
            Lisener(this, data);
        }


    }

    

}
