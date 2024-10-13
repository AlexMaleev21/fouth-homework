using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class CreditCard
    {
        public double MoneyAmount { get; set; }
        public int CVCCode { get; set; }

        public CreditCard(double moneyAmount, int CVCCode)
        {
            this.MoneyAmount = moneyAmount;
            this.CVCCode = CVCCode;
        }

        public static CreditCard operator +(CreditCard creditCard, double addition)
        {
            creditCard.MoneyAmount += addition;
            return creditCard;
        }

        public static CreditCard operator -(CreditCard creditCard, double decrease)
        {
            creditCard.MoneyAmount -= decrease;
            return creditCard;
        }

        public static bool operator ==(CreditCard creditCard1, CreditCard creditCard2)
        {
            if (creditCard1.CVCCode.Equals(creditCard2.CVCCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(CreditCard creditCard1, CreditCard creditCard2)
        {
            if (creditCard1.CVCCode.Equals(creditCard2.CVCCode))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(CreditCard creditCard1, CreditCard creditCard2)
        {
            if (creditCard1.MoneyAmount > creditCard2.MoneyAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(CreditCard creditCard1, CreditCard creditCard2)
        {
            if (creditCard1.MoneyAmount < creditCard2.MoneyAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(Object? obj)
        {
            var item = obj as CreditCard;
            return (this.MoneyAmount.Equals(item.MoneyAmount) && this.CVCCode.Equals(item.CVCCode));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.MoneyAmount.GetHashCode(), this.CVCCode.GetHashCode());
        }
    }
}
