using System;

namespace AutoFareCalculator
{
	public class AutoFareCalculator
	{
		public AutoFareCalculator ()
		{
		}

		public string CalculateFare(double distance)
		{
			double fare = (distance < 1.9) ? 25 : (distance - 1.9) * 13 + 25;
			return string.Format("{0:0.00}", fare);
		}
	}
}

