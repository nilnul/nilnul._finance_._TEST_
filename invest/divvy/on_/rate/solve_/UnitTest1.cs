using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using D = nilnul.finance.interest._DiscountX;

namespace nilnul._finance_._TEST_.invest.divvy.on_.rate.solve_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var ratePerYear = 10d / 100;



			double discount(double future, double r, double months) {
				return nilnul.finance.interest._DiscountX.OfExpRate(r, months, future);
				//return future / Math.Log(months * r);
			}

			/// where rate is per mongth;
			//Expression<Func<double,double>>

			var ofDicounts= new nilnul.finance.invest.divvy.on_.rate_.OfDiscounts(
				(
				Enumerable.Range(4,7).Select(

					
					months=> ((double)months -0.5,1d)
				))
				.Append(
					(11d -0.5,15d)
				)
				
			);
			Func<double,double>			expr = r => ofDicounts.op(r);

			var monthInterestRate=nilnul.num.real.ext.trans_.monotone_.strict.invert_.search_._BisectX._Search_0monotone(expr, 20);

			Debug.WriteLine(monthInterestRate);

			var yearRate = monthInterestRate * 12;
			var yearRateAsAdditional = nilnul.finance._accrual.rate_.AdditionalDbl.AdditionalOfExpander( yearRate );

			Debug.WriteLine(
				new nilnul.obj.Duo("additionalForYear",yearRateAsAdditional)
			);



		}
	}
}
