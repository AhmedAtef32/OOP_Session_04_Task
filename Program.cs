using Session_04_Task.Entities;
using Session_04_Task.Interfaces;

namespace Session_04_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PaymentMethod[] paymentMethods =
                {
                    new CashPayment(300),
                    new CreditCardPayment(1500),
                };

            foreach(PaymentMethod PM in paymentMethods)
            {
                PM.Pay();
                PM.PrintReceipt(PM);
                if (PM is IRefundable refundPM)
                {
                    refundPM.Refund();
                }
                Console.WriteLine("\n======================================\n");
            }

        }
    }
}
