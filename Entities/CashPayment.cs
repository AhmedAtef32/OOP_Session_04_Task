using System;
using System.Collections.Generic;
using System.Text;

namespace Session_04_Task.Entities
{
    public class CashPayment : PaymentMethod
    {
        public CashPayment(decimal amount):base(amount)
        {
            
        }
        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} To Cash.");

        }
    }
}
