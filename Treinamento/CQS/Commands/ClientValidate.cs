using FluentValidation;
using Treinamento.Dto;
using Treinamento.Dto.Client;

namespace Treinamento.CQS.Commands.ClientValidate
{
    public class ClientValidate : AbstractValidator<Client>
    {
        public ClientValidate()
        {
            RuleFor(Client => Client.Name)
                .NotNull()
                    .WithMessage("Name is required.");

            RuleFor(Client => Client.Email)
                .EmailAddress()
                    .WithMessage("e-mail is invalid.");

            RuleFor(Client => Client.Cpf)
                .GreaterThanOrEqualTo(11)
                    .WithMessage("CPF then or equal to 11 numbers");

            RuleFor(Client => Client.Password)
                .GreaterThanOrEqualTo(6)
                    .WithMessage("Password must contain at least 6 characters");
        }
    }
}
