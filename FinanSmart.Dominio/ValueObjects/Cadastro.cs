namespace FinanSmart.Dominio.ValueObjects
{
    public class Cadastro
    {
        public Guid ID { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }

    }
}
