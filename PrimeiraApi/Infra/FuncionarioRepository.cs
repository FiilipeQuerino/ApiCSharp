using PrimeiraApi.Model;

namespace PrimeiraApi.Infra
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly ContextoBanco _contexto = new ContextoBanco();

        public void add(Funcionario funcionario)
        {
            _contexto.Funcionario.Add(funcionario);
            _contexto.SaveChanges();
        }

        public List<Funcionario> Get()
        {
            return _contexto.Funcionario.ToList();
        }
    }
}
