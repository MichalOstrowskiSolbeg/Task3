using FluentValidation;
using ServiceLayer.DTO.Requests;

namespace ServiceLayer.Validators
{
    public class ReservationRequestValidator : AbstractValidator<ReservationRequest>
    {
        public ReservationRequestValidator(){
            RuleFor(x => x.EmployeeId).NotEmpty().WithMessage("This field cannot be empty");

            RuleFor(x => x.WorkplaceId).NotEmpty().WithMessage("This field cannot be empty");

            RuleFor(x => x.DateFrom).NotEmpty().WithMessage("This field cannot be empty");

            RuleFor(x => x.DateTo)
                .NotEmpty().WithMessage("This field cannot be empty")
                .GreaterThan(x => x.DateFrom).WithMessage("This field has to be greater than Date From");
        }
    }
}