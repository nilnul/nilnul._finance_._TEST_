using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._finance_._TEST_.interest.presentVal
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine(
				nilnul.finance.interest.PresentVal.Pv_payAtEnd_ofAdditionRate(
					nilnul.finance._accrual.rate_.add.convert_._SliceX.Slice(7.205/100d, 1d/12)
					,
					42
					,
					2102.17
				)
			);
		}
	}
}
