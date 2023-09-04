using FluentValidation;
using Treinamento.Dto;

namespace Treinamento.CQS.Commands.UserValidate
{
    public class UserValidate : AbstractValidator<User>
    {
        public UserValidate()
        {
            RuleFor(User => User.Email)
                .EmailAddress()
                    .WithMessage("e-mail is invalid.");

            RuleFor(User => User.password)
                .GreaterThanOrEqualTo(6)
                    .WithMessage("Password must contain at least 6 characters");
        }
    }
}
