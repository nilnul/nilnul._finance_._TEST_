using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.finance._test.entry.str
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Geometric()
		{
			Debug.WriteLine(
				nilnul.finance.entry.str.Periodic.PresentVal(
					1400,15*12,
					nilnul.finance.interest.Compound.GivenYearRate_returnMonthCompound(.05)
				
				)
			);

			Debug.WriteLine(
				nilnul.finance.entry.str.Periodic.PresentVal(
					1400,35*12,
					nilnul.finance.interest.Compound.GivenYearRate_returnMonthCompound(.05)
				
				)
			);


			Debug.WriteLine(
				nilnul.finance.entry.str.Periodic.PresentVal(
					400,15*12,
					nilnul.finance.interest.Compound.GivenYearRate_returnMonthCompound(.05)
				
				)
			);

			Debug.WriteLine(
				nilnul.finance.entry.str.Periodic.PresentVal(
					400,35*12,
					nilnul.finance.interest.Compound.GivenYearRate_returnMonthCompound(.05)
				
				)
			);



		}
	}
}
