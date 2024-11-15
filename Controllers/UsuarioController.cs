using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{		
		private CadastroService _cadastroService;

		public UsuarioController(CadastroService cadastroService)
		{
			_cadastroService = cadastroService;
		}

		[HttpPost]
		public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
		{
			await _cadastroService.Cadastra(dto);
			return Ok("Usuário cadastrado!");
		}
	}
}
