using System;
using System.Collections;

namespace Test1
{
	public class Data : IComparable
	{
		public int number;
		public string str;
		public Data()
		{
		}

		public Data(int Num, string str)
		{
			this.number = Num;
			this.str = str;
		}

		public int CompareTo(object obj)
		{
			return this.number - ((Data)obj).number;
		}
	}
}
