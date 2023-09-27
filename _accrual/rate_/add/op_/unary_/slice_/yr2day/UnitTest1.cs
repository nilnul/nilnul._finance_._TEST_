using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._finance_._TEST_._interest.rate_.add.convert_.slice_.yr2day
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var day = nilnul.finance._accrual.rate_.additional.op_.unary_._SliceX.Year2Day(0.01);
			Debug.WriteLine(day);

		}
	}
}
