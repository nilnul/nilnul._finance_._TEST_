using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.finance._test.currency.duo.exchange_.usdCny
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void UsdCny()
		{

			var rate = 6.78;

			var r = nilnul.finance.currency.duo.exchange_.UsdCny.Convert(150, rate, new num_.Positive(1000));

			Debug.WriteLine( 
				nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(r,4)
				);




		}
	}
}
