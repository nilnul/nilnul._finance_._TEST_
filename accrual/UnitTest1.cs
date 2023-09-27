using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._finance_._TEST_.accrual
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var rate =  nilnul.finance._accrual.rate_.AdditionalDbl.OfPercentIn365days(27);

			var accrual = nilnul.finance._AccrualX.EndValOfYears(1,rate, 30);

			Debug.WriteLine(accrual);


		}
	}
}
