using accumulatedinterest.api.Controllers;
using System.Collections.Generic;

namespace accumulatedinterest.api
{
    public class Calculator
    {
        public List<Interest> GetInterestPerYear(double percent, double balance, int year)
        {
            var interestList = new List<Interest>();
            var beforInterest = new Interest();
            for (int i = 0; i < year; i++)
            {
                double currentBalance = 0;
                if (beforInterest.SummaryPerYear == 0)
                {
                    currentBalance = balance;
                }
                else
                {
                    currentBalance = beforInterest.SummaryPerYear;
                }
                double currentInterest = CheckSumInterest(currentBalance, percent); ;
                double currentSummaryPerYear = currentBalance + currentInterest;

                beforInterest = new Interest
                {
                    Year = i + 1,
                    OutstandingPerYear = currentBalance,
                    InterestPerYear = currentInterest,
                    SummaryPerYear = currentSummaryPerYear,
                };
                interestList.Add(beforInterest);
            }
            return interestList;
        }

        public double CheckSumInterest(double percent, double balance)
        {
            return balance * (percent / 100);
        }
    }
}
