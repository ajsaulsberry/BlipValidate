using System;
using System.ComponentModel.DataAnnotations;

namespace BlipValidate.Data.ViewModels 
{
    public class CustomerAddViewModel
    {
        [Display(Name = "Company Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string CompanyName {get; set; }

        [Display(Name = "HQ Country Code")]
        [StringLength(3, MinimumLength = 3)]
        public string HqCountryIso3 { get; set; }

        [Display(Name = "Number of Employees")]
        [Range(1, 2500000)]
        public int EmployeeCount { get; set; }

        [Display(Name = "Incorporated")]
        [DataType(DataType.Date)]
        public DateTime Incorporated { get; set; }

        public bool Nonprofit { get; set; }
    }
}