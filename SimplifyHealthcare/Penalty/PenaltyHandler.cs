using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty
{
    public static class PenaltyHandler
    {
        public static void ServiceDisconnectionPenaltyCharges(float amount)
        {
            Console.WriteLine("Disconnection charges=" + amount);
        }
        public static void NotificationPenaltyCharges(float amount)
        {
            Console.WriteLine("Notification charges=" + amount);
        }
    }
}
