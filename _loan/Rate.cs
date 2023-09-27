using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using RateX = nilnul.finance._accrual._RateX;


namespace nilnul.finance._test._loan
{
	[TestClass]
	public class Rate
	{
		[TestMethod]
		public void YearFroDayRate()
		{
			Debug.WriteLine(
				RateX.YearRateFromDay(.4d / 1000)
				
			);

		}
		[TestMethod]
		public void Periods2Period()
		{
			Debug.WriteLine(
				RateX.MultiplePeriodRate2SinglePeriodRate(.1, 365)
				
			);

		}
	}
}
