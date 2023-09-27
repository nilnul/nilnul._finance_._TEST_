using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.finance._test._interest.rate.convert_.simple2compound
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void yearSimple2dayCompound()
		{
			Debug.WriteLine(
				nilnul.finance._accrual.rate.convert_.Simple2Compound.YearSimple2DayCompound(.05)
			);
		}
	}
}
