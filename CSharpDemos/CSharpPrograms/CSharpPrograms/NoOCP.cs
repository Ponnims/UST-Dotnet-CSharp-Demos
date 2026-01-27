using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{

    class Payement
    {         public enum PayementType
        {
            CreditCard,
            DebitCard,
            NetBanking,
            UPI,
            Gpay,
            PhonePe
        }
        public void ProcessPayment(PayementType payementType)
        {
            if (payementType == PayementType.CreditCard)
            {
                // Process credit card payment
            }
            else if (payementType == PayementType.DebitCard)
            {
                // Process debit card payment
            }
            else if (payementType == PayementType.NetBanking)
            {
                // Process net banking payment
            }
            else if(payementType == PayementType.UPI)
            {
                // Process UPI payment
            }
            else if (payementType == PayementType.Gpay  )
            {
                // Process Gpay payment
            }
            else if (payementType == PayementType.PhonePe)
            {
                // Process PhonePe payment
            }
        }
    }
    internal class NoOCP
    {
    }
}
