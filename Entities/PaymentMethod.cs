using System;
using System.Collections.Generic;
using System.Text;

namespace Session_04_Task.Entities
{
    public abstract class PaymentMethod
    {
        public decimal Amount { get; }
        
        public PaymentMethod(decimal amount)
        {
            Amount = amount;
        }

        public void PrintReceipt(PaymentMethod paymentMethod)
        {
            Console.WriteLine($"{paymentMethod.GetType().Name}  Paid  ${Amount}");
        }

        public abstract void Pay();
    }
}
