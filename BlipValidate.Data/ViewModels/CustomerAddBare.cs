using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlipValidate.Data.ViewModels
{
    public class CustomerAddBareViewModel
    {
        public string CompanyName { get; set; }

        public string HqCountryIso3 { get; set; }

        public int EmployeeCount { get; set; }

        public DateTime Incorporated { get; set; }

        public bool Nonprofit { get; set; }

    }
}
