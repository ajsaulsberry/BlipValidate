using System;
using System.ComponentModel.DataAnnotations;

namespace BlipValidate.Data.ViewModels
{
    public class CustomerAddViewModel
    {
        [Display(Name = "Company Name", Prompt = "Registered name of the company")]
        [StringLength(100, MinimumLength = 5)]
        [Required]
        public string CompanyName { get; set; }

        [Display(Name = "HQ Country Code")]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(@"[A-Za-z]{3}", ErrorMessage = @"The country code must be three letters.")]
        [Required]
        public string HqCountryIso3 { get; set; }

        [Display(Name = "Number of Employees")]
        [Range(1, 2500000)]
        public int EmployeeCount { get; set; }

        [Display(Name = "Incorporated")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? Incorporated { get; set; }

        public bool Nonprofit { get; set; }

        [Display(Name = "Max. Stock Price")]
        [Range(1, 5000)]
        public decimal? StockPriceMax { get; set; }

        [Display(Name = "Audit Date")]
        [DataType(DataType.Date)]
        // Nullable required to prevent initialization from creating a default value of 01/01/0001 00:00:00.
        public DateTime? AuditDate { get; set; }

        public DateTime EarliestAudit { get; set; }

        public DateTime LatestAudit { get; set; }
    }
}