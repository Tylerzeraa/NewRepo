namespace FinanSmart.Dominio.Interface.Repository
{
    public interface ILoginService
    {
        bool IsValid(string email, string password);
    }
}
