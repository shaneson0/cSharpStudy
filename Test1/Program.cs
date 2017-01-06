using System;
using Test1.EventTets;

namespace Test1
{
	class MainClass
	{
		public static void Main(string[] args)
		{

            ReadData rd = new ReadData("data.txt");
            DataArray dataArray = rd.ReadText();

            int Length = dataArray.GetLength();
            var datas = dataArray.GetdataArray();
            dataArray.Sort();


            WriteData wd = new WriteData("out.txt");
            wd.WriteText(dataArray);


            
            //自定义拓展EventArgs

            //Increment3 increment3 = new Increment3();
            //Dozen3 dozensCounter = new Dozen3(increment3);
            
            //increment3.DoCount();
            //Console.WriteLine(" Number of dozens = {0} ", dozensCounter.DozensCount);




            //事件的订阅者跟发布者2
            //Increment2 increment2 = new Increment2();
            //Dozens2 dozensCounter = new Dozens2(increment2);

            //increment2.DoCount();
            //Console.WriteLine("number of dozens = {0}", dozensCounter.DozensCount);



            ////订阅者跟发布者
            //Increment increment = new Increment();
            //Dozens dozens = new Dozens(increment);

            //increment.DoCount();
            //Console.WriteLine("{0} ", dozens.DozensCount);








		}


	}
}
