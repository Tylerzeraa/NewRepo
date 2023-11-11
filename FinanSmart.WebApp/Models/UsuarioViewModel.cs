
public class UsuarioViewModel
{
    public string Usuario { get; set; }
    public string Senha { get; set; }
    public bool ManterConectado { get; set; } = true;

    public bool Autenticado()
    {
        return Usuario == "tyler" && Senha == "1234";
    }


}