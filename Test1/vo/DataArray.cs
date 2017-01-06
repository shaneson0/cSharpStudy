using System;
using System.Collections.Generic;

namespace Test1
{
	public class DataArray
	{
		private List<Data> dataArray;
		private int key;
		
		public DataArray()
		{
			dataArray = new List<Data>();
		}

		public void Pushback(Data item)
		{
			dataArray.Add(item);
		}

		public List<Data> GetdataArray()
		{
			return this.dataArray;
		}

		public int GetLength()
		{
			return dataArray.Count;
		}

		public void Sort()
		{
			dataArray.Sort();
		}

		public void Print()
		{
			foreach (Data item in dataArray)
			{
				Console.WriteLine("{0} , {1} ", item.number, item.str);
			}
		}

		public void choose_key()
		{
			int len = dataArray.Count;

			Random rd = new Random();
			this.key = rd.Next(0,len-1) ;

		}

		public int get_key()
		{
			return this.key;
		}

	}
}
