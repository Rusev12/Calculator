using Calculator_Salar_WebApp.Models;
using System;

namespace Calculator_Salar_WebApp.Services
{
    public static class Formulas
    {
        // Formula for net salary and the employee taxes (CAS, CASS, taxable base, tax)
        public static NetSalaryCalculator ForNetSalaryAndEmployeeTaxesCalculationFromGrossSalary(NetSalaryCalculator _grossSalary)
        {
            var calculationNet = new NetSalaryCalculator()
            {
                GrossSalary = _grossSalary.GrossSalary,
                CharityTaxes = FormulaForCharityTaxes(_grossSalary),
                IncomeTax = FormulaForIncomeTax(_grossSalary),
                SocialContributions = FormulaForSotialContributions(_grossSalary),
                NetSalary = FormulaForNetSalary(_grossSalary)
            };

            return calculationNet;
        }

        private static decimal FormulaForCharityTaxes(NetSalaryCalculator grossSalary)
        {

            if (grossSalary.CharityTaxes > 0)
            {
                var procentOfSalary = (int)Math.Round((decimal)(100 * grossSalary.CharityTaxes) / grossSalary.GrossSalary);

                if (procentOfSalary <= 10 && grossSalary.GrossSalary > 1000)
                {
                    var procent = procentOfSalary / 100.00M;
                    grossSalary.GrossSalary -= (grossSalary.GrossSalary * procent);
                    grossSalary.CharityTaxes = grossSalary.GrossSalary ;
                }
                else if(procentOfSalary > 10 && grossSalary.GrossSalary > 1000)
                {
                    var tenProcent = (grossSalary.GrossSalary * 0.1M);
                    grossSalary.GrossSalary -= tenProcent;
                    var difference = grossSalary.CharityTaxes - tenProcent;

                    grossSalary.GrossSalary += difference;

                    grossSalary.CharityTaxes = grossSalary.GrossSalary ;
                }


            }

            return grossSalary.CharityTaxes;
        }

        // Formula for Income Taxes
        public static decimal FormulaForIncomeTax(NetSalaryCalculator _grossSalary)
        {
            if (_grossSalary.GrossSalary >= 1000)
            {
                _grossSalary.IncomeTax = (decimal)(0.10M * (_grossSalary.GrossSalary - 1000));
            }
            
            return _grossSalary.IncomeTax;
        }

        // Formula for Sotial Contributions
        public static decimal FormulaForSotialContributions(NetSalaryCalculator _grossSalary)
        {

            if ((_grossSalary.GrossSalary > 1000)  &&
                (_grossSalary.GrossSalary < 3000))
            {
                _grossSalary.SocialContributions = (decimal)(0.15M * (_grossSalary.GrossSalary - 1000));
            }
            else if(_grossSalary.GrossSalary >= 3000)
            {
                _grossSalary.SocialContributions = 300;
            }

            return _grossSalary.SocialContributions;
        }

        // Formula for net salary
        public static decimal FormulaForNetSalary(NetSalaryCalculator _grossSalary)
        {
            var netSalary = _grossSalary.GrossSalary - (_grossSalary.IncomeTax + _grossSalary.SocialContributions);

            return netSalary;
        }
    }
}
