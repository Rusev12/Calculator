//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalaryCalculator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DailyPayment
    {
        public System.Guid DailyId { get; set; }
        public System.DateTime Date { get; set; }
        [Display(Name = "Time Start")]
        public System.TimeSpan TimeStart { get; set; }
        [Display(Name = "Time End")]
        public System.TimeSpan TimeEnd { get; set; }
        [Display(Name = "Total Minutes")]
        public Nullable<int> TotalMinutes { get; set; }
        [Display(Name = "Total Hours")]
        public Nullable<double> TotalHours { get; set; }
        [Display(Name = "Hourly Rate")]
        public Nullable<decimal> HourlyRate { get; set; }
        [Display(Name = "Daily Payment")]
        public Nullable<decimal> DailyPayment1 { get; set; }
    }
}
