﻿using FidlyAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.Dto
{
    public class Min18YearsIfMemberDto : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customerDto = (CustomerDto)validationContext.ObjectInstance;

            if (customerDto.MembershipTypeId == MembershipType.Unknown ||
                customerDto.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customerDto.BirthDate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customerDto.BirthDate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to be on a membership.");
        }
    }
}