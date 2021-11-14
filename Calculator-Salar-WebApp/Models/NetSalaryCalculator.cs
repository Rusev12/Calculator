using System.ComponentModel.DataAnnotations;


namespace Calculator_Salar_WebApp.Models
{
    public class NetSalaryCalculator
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Salary is required!")]
        [Range(1, int.MaxValue, ErrorMessage = "Salary has to be positive number!")]
        [Display(Name = "Salary Bruto")]
        public decimal GrossSalary { get; set; }

        [Display(Name = "Income tax")]
        public decimal IncomeTax { get; set; }

        [Display(Name = "Social contributions")]
        public decimal SocialContributions { get; set; }

        [Display(Name = "Salar Net")]
        public decimal NetSalary { get; set; }

        [Display(Name = "After Charity taxes")]
        [Range(1, int.MaxValue, ErrorMessage = "Salary has to be positive number!")]
        public decimal CharityTaxes { get; set; }

    }
}
