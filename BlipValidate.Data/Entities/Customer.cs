using System;
using System.ComponentModel.DataAnnotations;

namespace BlipValidate.Data.Entities
{
    public class Customer
    {
        [MaxLength(100)]
        [Required]
        public string CompanyName {get; set; }

        [MaxLength(3)]
        public string HqCountryIso3 { get; set; }

        public int EmployeeCount { get; set; }

        [DataType(DataType.Date)]
        public DateTime Incorporated { get; set; }
    }
}