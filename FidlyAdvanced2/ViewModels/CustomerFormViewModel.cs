using FidlyAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            BirthDate = customer.BirthDate;
            MembershipTypeId = customer.MembershipTypeId;
        }

        public CustomerFormViewModel()
        {
            Id = 0;
        }

        public String Title
        {
            get
            {
                return (Id == 0) ? "New Customer" : "Edit Customer";
            }
        }
    }
}