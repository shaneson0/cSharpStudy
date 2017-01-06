using System;

namespace Test1
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			ReadData rd = new ReadData("/Users/csx/Projects/Test1/Test1/data.txt");
			DataArray dataArray = rd.ReadText();

			int Length = dataArray.GetLength();
			var datas = dataArray.GetdataArray();
			dataArray.Sort();

			dataArray.Print();

			WriteData wd = new WriteData("/Users/csx/Projects/Test1/Test1/out.txt");
			wd.WriteText(dataArray);

		}


	}
}
