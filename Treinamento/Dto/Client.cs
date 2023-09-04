namespace Treinamento.Dto.Client
{
    public class Client : BaseRegister
    {
        public Guid id = Guid.NewGuid();
        public string name { get; set; }
        public int cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        //public int age = CalculaIdade(dataNascimento);

        private static int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;

            return (idade == 0) ? 0 : idade;
        }

    }





}
