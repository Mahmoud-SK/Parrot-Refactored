using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
	public class African : Parrot
	{
		private readonly int _numberOfCoconuts;

		public African(int numberOfCoconuts)
		{
			_numberOfCoconuts = numberOfCoconuts;
		}
		public override double GetSpeed()
		{
			return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
		}
	}
}
