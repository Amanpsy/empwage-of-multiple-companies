using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_wage_multiple_companies
{
    public class Calempwage
    {

        public const int emp_part = 1;
        public const int emp_full = 2;

        public static int computeEmpwage(string companyName, int empRateperHour, int hoursperMonth, int numberOfworkingDays)

        {
            int totalWorkingHours = 0; 
            int totalworkingdays = 0;
            while (totalWorkingHours < hoursperMonth && totalworkingdays < numberOfworkingDays)
            {
                int emphours = 0;
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case emp_part:
                        emphours = 4;
                        break;

                    case emp_full:
                        emphours = 8;
                        break;
                    default:
                        emphours = 0;
                        break;
                }
                totalWorkingHours = emphours + totalWorkingHours;

            }
            int totalEmpwage = empRateperHour * totalWorkingHours;
           

            Console.WriteLine("total employee wage   " + totalEmpwage);
            Console.WriteLine("total employe wage for company  " +  companyName  , "is :-   " + totalEmpwage);
            return totalEmpwage;

            }

        static  void Main(string[] args)
        {

            computeEmpwage("deloitte", 20, 3, 90);
            computeEmpwage("microsoft", 30, 45, 70);
            computeEmpwage("capgemini", 40, 35, 7);
            
        }

        
    }

}