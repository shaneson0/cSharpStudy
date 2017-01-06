using System;
using System.Text;
using System.IO;

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
			using (var file = File.OpenWrite(path))
			{
				using (var filestream = new StreamWriter(file, Encoding.UTF8))
				{
					var list = dataArray.GetdataArray();
					foreach (var item in list)
					{
						
						filestream.WriteLine("{0} , {1} ", item.number, item.str);
					}
				}
			}
		}

	}
}
