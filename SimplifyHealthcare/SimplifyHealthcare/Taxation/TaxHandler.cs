﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxation
{
    public static class TaxHandler
    {

        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income tax is deducted from your account is :" + factor);
        }
        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service Tax: " + factor);
        }
        public static void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Professional Tax :" + factor);
        }
        public static void PayGST(float factor)
        {
            Console.WriteLine("GST tax : " + factor);
        }
    }
}
