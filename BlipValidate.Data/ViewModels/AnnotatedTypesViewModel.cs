using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace BlipValidate.Data.ViewModels
{
    public class AnnotatedTypesViewModel
    {
        [CreditCard]
        public string CreditCardNumber { get; set; }

        [DataType(DataType.Currency)]
        public decimal PurchasePrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TransactionTimestamp { get; set; }

        [DataType(DataType.Duration)]
        public DateTime SessionLength { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(254, ErrorMessage =@"The email address cannot be more than 254 characters.")]
        public string Email { get; set; }

        [DataType(DataType.Html)]
        public string FileName { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [DataType(DataType.MultilineText)]
        public string LongAnswer { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }

        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [DataType(DataType.Text)]
        public string DisplayText { get; set; }

        [Display(Name = @"Order Time")]
        [DataType(DataType.Time)]
        [Required]
        public DateTime OrderTime { get; set; }

        [DataType(DataType.Upload)]
        public string UploadFileName { get; set; }

        [Url]
        public string WebsiteAddress { get; set; }
    }
}
