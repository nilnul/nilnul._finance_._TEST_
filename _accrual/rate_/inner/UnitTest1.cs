using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._finance_._TEST_._interest.rate_.inner
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			Debug.WriteLine(
				nilnul.finance._accrual.rate_._InternalRateOfReturnX.Solve(
					new System.Collections.Generic.Dictionary<double, double>() {
						[0.5]=-20
						,
						[4]=1
						,
						[5]=1
						,
						[6]=1
						,
						[7]=1
						,
						[8]=1
						,
						[9]=1
						,
						[10]=1
						,
						[11]=15
						,

					}
				)
			);

			Debug.WriteLine(
				nilnul.finance._accrual.rate_.exp_._AdditionalX.Exp(0.1) /12
			);
		}
	}
}
