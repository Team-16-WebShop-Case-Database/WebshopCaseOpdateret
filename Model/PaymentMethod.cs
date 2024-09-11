using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class PaymentMethod
    {
        public int PaymentMethodID { get; set; }
        public PaymentMethodType PaymentMethodName { get; set; } 
        public int PointsSpent { get; set; }

        public PaymentMethod(int paymentMethodID, PaymentMethodType paymentMethodName, int pointsSpent)
        {
            PaymentMethodID = paymentMethodID;
            PaymentMethodName = paymentMethodName;
            PointsSpent = pointsSpent;
        }
    }

    public enum PaymentMethodType //Har brugt enum her da der kun er et bestemt antal af betalingsmetoder
    {
        DebitCard,
        PayPal,
        Points,
        BankTransfer,
        MobilePay
    }
}
