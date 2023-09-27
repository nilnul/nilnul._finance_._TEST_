using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.finance._test.currency.duo.exchanges
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void currencyExchanges()
		{

			var usdRate = 6.78;

			var usd = nilnul.finance.currency.duo.exchange_.UsdCny.Convert(-1796.05
, usdRate, new num_.Positive(1000));

			Debug.WriteLine(
				nilnul.num.real.to_._RadixX._Clamp2Dec_DigitsAftDot(usd, 4)
				);


			var wonRate =  1990d / 337717.00 ;

			var won = nilnul.finance.currency.duo.exchange_.UsdCny.Convert(-337717.00
, wonRate, new num_.Positive(1000));


			Debug.WriteLine(
				nilnul.num.real.to_.RadixX.ToDec(won, 4)
				);


			var total = usd + won;
			Debug.WriteLine(
				nilnul.num.real.to_.RadixX.ToDec(total, 4)
				);


		}
	}
}
