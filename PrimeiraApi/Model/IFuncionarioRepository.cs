namespace PrimeiraApi.Model
{
    public interface IFuncionarioRepository
    {
        void add (Funcionario funcionario);

        List<Funcionario> Get();
    }
}
