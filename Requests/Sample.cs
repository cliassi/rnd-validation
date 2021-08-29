using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidationRnD.ValidationRules;

namespace ValidationRnD.Requests
{
    public class Sample
    {
        //[RegularExpression(@"^[a-zA-Z\s]$", ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        public double Amount { get; set; }
    }

    public class SampleValidator : AbstractValidator<Sample>
    {
        public SampleValidator()
        {
            RuleFor(x => x.Name).Length(5, 50).Matches(Validations.AlphaAndSpace).WithMessage("Name has invalid characters");
            RuleFor(x => x.Email).EmailAddress().Matches(Validations.Email).WithMessage("Email has invalid characters");
            RuleFor(x => x.Phone).Length(10, 11).Matches(Validations.Numeric).Must((f,t) => f.Phone.StartsWith("01")).WithMessage("Phone number must start with 01");
            RuleFor(x => x.Amount).InclusiveBetween(1, 3000).WithMessage("Amount must be between 0 and 3000");
        }
    }
}
