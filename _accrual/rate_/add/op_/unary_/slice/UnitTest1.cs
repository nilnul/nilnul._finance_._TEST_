using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._finance_._TEST_._interest.rate_.add.convert_.slice
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var month = nilnul.finance._accrual.rate_.add.convert_._SliceX.Year2Month(7.205 / 100);
			Debug.WriteLine(month);
			var year = Math.Pow((1 + month), 12) - 1;

		}
	}
}
