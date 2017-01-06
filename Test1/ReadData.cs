

using System.IO;
using System.Text;
using System;

namespace Test1
{
	public class ReadData
	{
		public string path ;
		public ReadData(string str)
		{
			this.path = str;
		}

		public DataArray ReadText()
		{
			DataArray dataArray = new DataArray();
			const Int32 Buffersize = 128;


            Console.WriteLine("从文本中读取数据");
			using (var FileStream = File.OpenRead(path))
			{
				using (var stringReader = new StreamReader(FileStream, Encoding.UTF8, true, Buffersize))
				{
					string line ;

					while ((line = stringReader.ReadLine()) != null)
					{
						string[] sArray = line.Split(',');


						//Console.WriteLine("len : {0} ", sArray.Length);
						Console.WriteLine("{0} {1}", sArray[0], sArray[1]);

						//DataArray[i] = new Data(int.Parse(sArray[0]), sArray[1] );
						Data data = new Data(int.Parse(sArray[0]), sArray[1]);
						dataArray.Pushback( data ) ;
					}

				}


			}

			dataArray.choose_key();

			return dataArray;
		}


	}
}
