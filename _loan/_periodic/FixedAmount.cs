using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using RateX = nilnul.finance._accrual._RateX;
using nilnul.finance._loan._periodic;


namespace nilnul.finance._test._loan._periodic
{
	[TestClass]
	public class FixedAmount
	{
		[TestMethod]
		public void ComputePeriodRate_payAtEnd()
		{
			Debug.WriteLine(
				nilnul.finance._loan._periodic.FixedAmount.ComputePeriodRate_payAtEnd(
					24,100000d/24+830,100000	
				)
				
			);
			Debug.WriteLine(
				
					nilnul.finance._loan._periodic.FixedAmount.Compute12PeriodRate_payAtEnd(
						24,100000d/24+830,100000	
					)
				
			);


			Debug.WriteLine(
				nilnul.finance._loan._periodic.FixedAmount.ComputePeriodRate_payAtEnd(
					12,100000d/12+830,100000	
				)
				
			);
			Debug.WriteLine(
				nilnul.finance._loan._periodic.FixedAmount.Compute12PeriodRate_payAtEnd(
					12,100000d/12+830,100000	
				)
				
			);

		}
	
	}
}
