using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
	public class European : Parrot
	{
		public European()
		{

		}
		public override double GetSpeed()
		{
			return GetBaseSpeed();
		}
	}
}
