using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStrategy
{
    public class CashContext
    {
        private CashSuper cashSuper = null;

        public CashContext(string type,string paramA,string paramB)
        {
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "打折":
                    cashSuper = new CashRebate(paramA);
                    break;
                case "满返":
                    cashSuper = new CashReturn(paramA, paramB);
                    break;
                default:
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cashSuper.AcceptCash(money);
        }
    }
}
