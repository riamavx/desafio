using FluentValidation;
using Treinamento.Dto;
using Treinamento.Dto.Client;

namespace Treinamento.CQS.Commands.ClientValidate
{
    public class ClientValidate : AbstractValidator<Client>
    {
        public ClientValidate()
        {
            RuleFor(Client => Client.name)
                .NotNull()
                    .WithMessage("Name is required.");

            RuleFor(Client => Client.Email)
                .EmailAddress()
                    .WithMessage("e-mail is invalid.");

            RuleFor(Client => Client.cpf)
                .GreaterThanOrEqualTo(11)
                    .WithMessage("CPF then or equal to 11 numbers");

            RuleFor(Client => Client.password)
                .GreaterThanOrEqualTo(6)
                    .WithMessage("Password must contain at least 6 characters");
        }
    }
}
