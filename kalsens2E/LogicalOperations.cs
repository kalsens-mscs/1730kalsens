﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalsens2E
{
    
    public class LogicalOperations
    {
        public static bool q0l(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }

        public static bool q02(int timeInService)
        {
           return timeInService <= 4 || timeInService >= 12;
        }

        public static bool q03(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }

        public static bool q04(int counter, bool isValid, int years)
        {
            return isValid == true & counter++ < years;
        }

        public static bool q05(int counter, bool isValid, int years)
        {
            return isValid == true || counter++ < years;
        }

        public static bool q06(int counter, bool isValid, int years)
        {
            return isValid == true | counter++ < years;
        }

        public static bool q07(DateTime startDate, DateTime expirationDate, DateTime date, bool isValid)
        {
            return date > startDate && date < expirationDate || isValid == true;
        }

        public static bool q08(decimal thisYTD, decimal lastYTD, string empType, int startYear, int currentYear)
        {
            return thisYTD > lastYTD || empType == "Part time" && startYear < currentYear;
        }

        internal static object q01(decimal subtotal)
        {
            throw new NotImplementedException();
        }

        public static bool q09(int counter, int years)
        {
            return !(counter++ >= years);
        }

        public static bool q10(int a, int b, int c, int d)
        {
            return a > b && b < c || c < d;
        }

 
    }
}
