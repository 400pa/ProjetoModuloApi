using Microsoft.AspNetCore.Mvc;

namespace MODULOAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()
            };

            return Ok(obj);

        }
        [HttpGet("Apresentar")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja muito bem vindo!";
            return Ok(new {mensagem});

            
        }
    }
}