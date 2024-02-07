using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doador.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorService;
        public DoadorController(IDoadorService doadorService)
        {
            _doadorService = doadorService;
        }

        [HttpPost]
        [Route("CadastrarDoador")]
        public async Task<IActionResult> PostAsync(DoadorCommand command)
        {
            return Ok(await _doadorService.PostAsync(command));
        }

        [HttpGet]
        [Route("BuscarDoadores")]
        public async Task<IActionResult> GetAll()
        {
            var doadores = await _doadorService.GetAll();
            return Ok(doadores);
        }

    }
}
