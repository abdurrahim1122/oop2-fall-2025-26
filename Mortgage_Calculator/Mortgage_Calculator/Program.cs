using System;
using System.Globalization;

class MortgageCalculator
{
    static void Main()
    {
        double principal, annualRate, monthlyRate;
        int years, totalPayments;
        double monthlyPaymentUSD, monthlyPaymentBDT;
        const double exchangeRate = 120; 

        
        
        
        Console.WriteLine("Mortgage Calculator ");
        Console.Write("Enter the loan amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

       
     Console.Write("Enter annual interest: ");
      annualRate = Convert.ToDouble(Console.ReadLine());
      monthlyRate = annualRate/12/100;

      
        Console.Write("Enter the loan term (years): ");
        years = Convert.ToInt32(Console.ReadLine());
        totalPayments = years*12;
        double Value = Math.Pow(1+monthlyRate,totalPayments);
        monthlyPaymentUSD = principal*(monthlyRate*Value)/(Value -1);
        monthlyPaymentBDT = monthlyPaymentUSD*exchangeRate;

        CultureInfo us = new CultureInfo("en-US");
        Console.WriteLine("\nYour monthly payment:");
        Console.WriteLine("USD: " + monthlyPaymentUSD.ToString("C2", us));
        Console.WriteLine("BDT:"+monthlyPaymentBDT.ToString("N2"));

        Console.WriteLine("\nTotal payment over "+years+ " years:");
        Console.WriteLine("USD "+ (monthlyPaymentUSD * totalPayments).ToString("C2", us));
        Console.WriteLine("BDT:" + (monthlyPaymentBDT * totalPayments).ToString("N2"));

        
    }
}
