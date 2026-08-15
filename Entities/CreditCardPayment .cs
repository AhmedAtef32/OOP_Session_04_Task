using Session_04_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session_04_Task.Entities
{
    public class CreditCardPayment:PaymentMethod,IRefundable
    {
        public CreditCardPayment(decimal amount):base(amount)
        {
            
        }
        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} To Credit card.");
        }

        public void Refund()
        {
            Console.WriteLine($"Refunding {Amount} to credit card.");
        }
    }
}
