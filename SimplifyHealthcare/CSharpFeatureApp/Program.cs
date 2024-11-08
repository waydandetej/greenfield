using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxation;
using Penalty;
using Banking;

namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Handler.PayIncomeTax();
             Handler.PayProfessionalTax();
             Handler.PayIncomeTax();
             Handler.PayGST();


            */

            /* Operation opn1 = new Operation(Handler.PayIncomeTax);
             opn1.Invoke(30);
             Console.ReadLine();
 */      
            //object creation
            Account acct = new Account(15000);
            //event registration
            acct.underBalance += PenaltyHandler.ServiceDisconnectionPenaltyCharges;
            acct.underBalance += PenaltyHandler.NotificationPenaltyCharges;
            acct.overBalance += TaxHandler.PayIncomeTax;
            //object invocation
           
            acct.Withdraw(8000);
            acct.Deposit(400000);
            Console.ReadLine(); 


        }
    }
}
