using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using RateX = nilnul.finance._accrual._RateX;

namespace nilnul.finance._test.loan
{
	[TestClass]
	public class Mortgage
	{
		[TestMethod]
		public void Mortgage_Rate__test()
		{
			Debug.WriteLine(12069.96*.15);

			var x=nilnul.finance.loan.MortgageX.Rate_payAtEnd(36, 5546.45, 160000);

			Debug.WriteLine(
				RateX.MultiplePeriodRate2SinglePeriodRate(
					x,30
				)
			);


			var y=nilnul.finance.loan.MortgageX.Rate_payAtEnd(36, 5546.45, 160000);

			Debug.WriteLine(
				RateX.MultiplePeriodRate2SinglePeriodRate(
					x,30
				)
			);




		}


		[TestMethod]
		public void Mortgage_CreditCardInstallmentYearRate()
		{


			//var _dot64Rate = _CreditCardInstallmentYearRate(.0064);

			//var x = _CreditCardInstallmentYearRate(6997.48, 24, 41.98+291);

			//double y;
			//y = _CreditCardInstallmentYearRate(5.8 / 100,12);
			//Debug.WriteLine(y);

			Debug.WriteLine(
				_CreditCardInstallmentYearRate(9871.98, 24, 411.33+71.08)	
			);


			//汉口银行

			Debug.WriteLine(
				_CreditCardInstallmentYearRate(12069.96, 36, 50.29 + 335.28)	
			);

			Debug.WriteLine(
				_CreditCardInstallmentYearRate(50000,24,2083.33+375.00	)
			);


			Debug.WriteLine(
				_CreditCardInstallmentYearRate(2345.3,12,206)	
			);


			Debug.Assert(nilnul.num.real.double_.Eq.NoMoreThan1_1000000_(
				_CreditCardInstallmentYearRate(0),
				0));
			Debug.Assert(
				nilnul.num.real.double_.Eq.NoMoreThan1_1000000_(_CreditCardInstallmentYearRate(0.072)
				,
				.138417853
));




			
		}





		public double _CreditCardInstallmentYearRate(double chargeRate)
		{

			return nilnul.finance.loan.MortgageX.YearRateOfCreditInstallments(12, chargeRate);


			
		}
		public double _CreditCardInstallmentYearRate(double chargeRate, int periods=12)
		{

			return nilnul.finance.loan.MortgageX.YearRateOfCreditInstallments((uint)periods, chargeRate);


			
		}
		public double _CreditCardInstallmentYearRate(double presentVal, int monthCount, double monthPay)
		{

			return nilnul.finance.loan.MortgageX.YearRateOfCreditInstallments(presentVal, (uint)monthCount, monthPay);


			
		}

		public void Mortage_feePaidDownInAdvance() { 


			
		}
	}
}
