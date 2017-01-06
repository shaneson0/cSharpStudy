using System;
using System.Collections;

namespace Test1
{
	//public class TestData : IEnumerable
	//{

	//	string[] Colors = { "red", "Yellow", "Blue" };

	//	public TestData()
	//	{
	//	}

	//	public IEnumerator GetEnumerator()
	//	{
	//		return new
	//	}
	//}

	class ColorEnumerator : IEnumerator
	{
		string[] colors;
		int _position = -1;


		public ColorEnumerator(string[] theColors)
		{
			colors = new string[theColors.Length];
			for (int i = 0; i < theColors.Length; i++)
			{
				colors[i] = theColors[i];
			}
		}

		public object Current
		{
			get
			{
				if (_position == -1)
					throw new InvalidOperationException();
				if (_position >= colors.Length)
					throw new InvalidOperationException();

				return this.colors[_position];
			}
		}

		public bool MoveNext()
		{
			if (_position < colors.Length - 1)
			{
				_position++;
				return true;
			}
			else
				return false;
		}

		public void Reset()
		{
			_position = -1;
		}

	}


	class Spectrum : IEnumerable
	{
		string[] Colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

		
		public IEnumerator GetEnumerator()
		{

			return new ColorEnumerator(Colors);
		}


	}

		

}
