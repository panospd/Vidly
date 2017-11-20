using System;
using System.Collections.Generic;
using System.Linq;
using Vidly.Models;
using System.Web;

namespace Vidly.ViewModels
{
    public class NewCustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}