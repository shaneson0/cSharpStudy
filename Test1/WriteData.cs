using System;
using System.Text;
using System.IO;
using Test1.EventClass;

namespace Test1
{
	public class WriteData
	{
		public string path;
		public WriteData(string p)
		{
			this.path = p;
		}

		public void WriteText(DataArray dataArray)
		{
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber(publisher);



            Console.WriteLine("开始把数据写入文本..");
			using (var file = File.OpenWrite(path))
			{
				using (var filestream = new StreamWriter(file, Encoding.UTF8))
				{
					var list = dataArray.GetdataArray();
					foreach (var item in list)
					{
                        if ( dataArray.EqualKey(item.number) )
                            publisher.Publish(new IncrementerData(item.number, item.str));
                            
						filestream.WriteLine("{0} , {1} ", item.number, item.str);
					}
				}
			}
		}

	}
}
