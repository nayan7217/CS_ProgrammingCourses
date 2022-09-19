
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_MethodOverriding
{
    public  class Staff
    {
        public int basicPay = 150000;

        public int  rateOfTax = 0;

        public int houseAllowence = 10000;


        // CalculateIncome method will behave diffent for all the doctor nurse and technician classes
        // hence it must have to Overriding

        // Method overriding is the phenomenon by which we can provide the Different implementation of the 
        // method in the derived classes
        // To override the method it is compulsary to use the inheritence
        // Without Inheritence Method Overloading is not possible
        // Method overloading require the permission from the parent to override the method
        // To give that permission to the child classes we use the Virtual Keyword;
        // To Implement the same method in the derived classes we use the override keyword
        // But Method overriding is not the compulsury for all the derived classes
        // If the class want to do the method overloading it can if dont want to do that then it totoaly 
        // Depend on the derived class itself

        public virtual int CalculateIncome()
        {
            return basicPay+houseAllowence-rateOfTax*basicPay;
        }
    }
    public class Doctor:Staff
    {
        public int NoOfPatientMonitored { get; set; }

        public int RateForCheacking { get; set; }

        public int NoOfOperation { get; set; }

        public Doctor(int a, int b, int c)
        {
            this.NoOfPatientMonitored = a;
            this.RateForCheacking = b;
            this.NoOfOperation = c;

        }

        public override int CalculateIncome()
        {
            //  base.CalculateIncome();
            //  Above statement is used to call the base classs method

            // here we have to write the new implementation for the method;

            int totalIncome = NoOfPatientMonitored * RateForCheacking + NoOfOperation * 10000 + basicPay;
            return totalIncome - totalIncome * rateOfTax;
        }

    }
}
