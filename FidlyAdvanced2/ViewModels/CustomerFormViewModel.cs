using FidlyAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}