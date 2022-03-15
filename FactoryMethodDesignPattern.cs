using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    class FactoryMethodDesignPattern
    {

        public abstract class CreditCards
        {
            public abstract string CardType { get; }
            public abstract int CreditLimit { get; set; }
            public abstract int AnnualCharge { get; set; }
        }


        public class MoneyBackCreditCard : CreditCards
        {
            public string _CardType;
            public int _CreditLimit;
            public int _AnnualCharge;

            public MoneyBackCreditCard(int creditLimit, int annualCharge)
            {
                _CardType = "MoneyBack";
                _CreditLimit = creditLimit;
                _AnnualCharge = annualCharge;
            }

            public override int AnnualCharge
            {
                get { return _AnnualCharge; }
                set { _AnnualCharge = value; }
            }


            public override int CreditLimit
            {
                get { return _CreditLimit; }
                set { _CreditLimit = value; }
            }

            public override string CardType
            {
                get { return _CardType; }
            }
        }


        public class TitaniumCreditCard : CreditCards
        {
            public string _CardType;
            public int _CreditLimit;
            public int _AnnualCharge;

            public TitaniumCreditCard(int creditLimit, int annualCharge)
            {
                _CardType = "Titanium ";
                _CreditLimit = creditLimit;
                _AnnualCharge = annualCharge;
            }

            public override int AnnualCharge
            {
                get { return _AnnualCharge; }
                set { _AnnualCharge = value; }
            }


            public override int CreditLimit
            {
                get { return _CreditLimit; }
                set { _CreditLimit = value; }
            }

            public override string CardType
            {
                get { return _CardType; }
            }
        }


        //creator
        public abstract class CardFactory
        {
            public abstract CreditCards GetCreditCards();
        }


        //MoneyBack CreditCard Factory
        public class MoneyBackCreditCardFactory: CardFactory
        {
          
            public int _CreditLimit;
            public int _AnnualCharge;

            public MoneyBackCreditCardFactory(int creditLimit, int annualCharge)
            {
          
                _CreditLimit = creditLimit;
                _AnnualCharge = annualCharge;
            }

            public override CreditCards GetCreditCards()
            {
                return new MoneyBackCreditCard(_CreditLimit, _AnnualCharge);
            }
        }



        //MoneyBack CreditCard Factory
        public class TitaniumCreditCardFactory : CardFactory
        {

            public int _CreditLimit;
            public int _AnnualCharge;

            public TitaniumCreditCardFactory(int creditLimit, int annualCharge)
            {

                _CreditLimit = creditLimit;
                _AnnualCharge = annualCharge;
            }

            public override CreditCards GetCreditCards()
            {
                return new TitaniumCreditCard(_CreditLimit, _AnnualCharge);
            }
        }


    }





}

