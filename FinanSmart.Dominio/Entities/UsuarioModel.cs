namespace FinanSmart.Dominio.Entities

{
    public class UsuarioModel
    {

    public int Id { get; set; }
    public string Name { get; set; }

    public string login { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
    public PerfilEnum Perfil { get; set; }

    public string Senha { get; set; }

    public DateTime DataCadastro { get; set; }
    
    public DateTime? DataAtualizacao { get; set; }

    }
}
