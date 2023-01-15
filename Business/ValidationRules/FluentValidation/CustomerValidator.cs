using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.IdentityNumber).Length(11).WithMessage("Tc Kİmlik No 11 haneli olmalıdır");
            RuleFor(c => c.DateOfBirth).Must(BeAValidDate);
            RuleFor(c => c.FirstName).Length(2, 30);
            RuleFor(c => c.LastName).Length(2, 30);
            RuleFor(c => c.PhoneNumber).Length(10).WithMessage("Telefon numarası 10 haneli olamlıdır");
        }
        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
