using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Model;
using PrimeiraApi.ViewModel;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/v1/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpPost]
        public IActionResult Add(FuncionarioViewModel funcionarioView)
        {   
            var funcionario = new Funcionario(funcionarioView.Nome, funcionarioView.Idade);

            _funcionarioRepository.add(funcionario);    

            return Ok();
        }

        [HttpGet]
        public IActionResult Get () 
        {
            var funcionarios = _funcionarioRepository.Get();

            return Ok(funcionarios); 
        }
    }
}
