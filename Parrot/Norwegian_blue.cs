using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
	public class Norwegian_blue : Parrot
	{
		private readonly bool _isNailed;
		private readonly double _voltage;

		public Norwegian_blue(bool isNailed, double voltage)
		{
			_isNailed = isNailed;
			_voltage = voltage;

		}
		public override double GetSpeed()
		{
			return _isNailed ? 0 : GetBaseSpeed(_voltage);
		}
	}
}
