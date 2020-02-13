using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SOLID_OCP
{
    class CashPayment : IPaymentMethod
    {

        bool IPaymentMethod.processPayment(double amount)
        { 
            return CashPayment.processPayment(amount);
            
        }
        public static bool processPayment(double amount)
        {
            Console.WriteLine("Processing payment with Cash in CashPayment");
            // 1- Ask for tendered amount
            // 2- verify if amount is enough
            return true; ;
        }
    }
}
