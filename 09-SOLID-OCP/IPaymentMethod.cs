using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SOLID_OCP
{
    interface IPaymentMethod
    {
        bool processPayment(double amount);
    }
}
