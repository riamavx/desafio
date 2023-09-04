namespace Treinamento.Dto.Client
{
    public class Client : BaseRegister
    {
        public Guid Id = Guid.NewGuid();
        public string Name { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public int age => CalculaIdade();

        private int CalculaIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            return (idade == 0) ? 0 : idade;
        }

    }





}
