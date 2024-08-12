using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFT.Utility.CustomValidations
{
	public class DateInFuture : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value is DateTime dateValue)
			{
				if (dateValue < DateTime.Today)
				{
					return new ValidationResult("Datum ne sme biti v preteklosti!");
				}
			}
			else
			{
				return new ValidationResult("Invalid date format.");
			}

			return ValidationResult.Success;
		}
	}
}
