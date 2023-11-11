using System.ComponentModel.DataAnnotations;

namespace FinanSmart.Dominio.Entities
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Digire o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Digire o celular do contato")]
        [EmailAddress(ErrorMessage = "O celular informado não é valido!")]

        public string Celular { get; set; }



    }
}
