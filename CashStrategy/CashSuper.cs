using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashStrategy
{
    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }

    public class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }

    public class CashRebate : CashSuper
    {

        private double MoneyRebate { get; set; }

        public CashRebate(string moneyRebateString)
        {
            MoneyRebate = Convert.ToDouble(moneyRebateString);
        }

        public override double AcceptCash(double money)
        {
            return money * MoneyRebate;
        }
    }

    public class CashReturn : CashSuper
    {
        private double MoneyCondition { get; set; }
        private double MoneyReturn { get; set; }

        public CashReturn(string moneyConditionString, string moneyReturnString)
        {
            MoneyCondition = Convert.ToDouble(moneyConditionString);
            MoneyReturn = Convert.ToDouble(moneyReturnString);
        }
        public override double AcceptCash(double money)
        {
            if (money >= MoneyCondition)
            {
                return money - Math.Floor(money / MoneyCondition) * MoneyReturn;
            }

            return money;
        }
    }
}