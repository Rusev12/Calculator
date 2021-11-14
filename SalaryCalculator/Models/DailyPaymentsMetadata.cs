using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalaryCalculator.Models
{
    [MetadataType(typeof(DailyPayment.Metadata))]
    public partial class DailyPayment
    {
        sealed class Metadata
        {
            [Key]
            public System.Guid DailyId { get; set; }

            [Required(ErrorMessage = "Please enter a date in the format: YYYY-MM-DD")]
            public System.DateTime Date { get; set; }


            [Required(ErrorMessage = "Please enter a time in the format: HH:MM")]
            
            public System.TimeSpan TimeStart { get; set; }

            [Required(ErrorMessage = "Please enter a time in the format: HH:MM")]
            public System.TimeSpan TimeEnd { get; set; }


        }

    }
}