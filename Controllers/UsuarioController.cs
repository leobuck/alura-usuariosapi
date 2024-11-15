using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{		
		private UsuarioService _usuarioService;

		public UsuarioController(UsuarioService usuarioService)
		{
			_usuarioService = usuarioService;
		}

		[HttpPost("cadastro")]
		public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
		{
			await _usuarioService.Cadastra(dto);
			return Ok("Usuário cadastrado!");
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginUsuarioDto dto)
		{
			await _usuarioService.Login(dto);
			return Ok("Usuário autenticado!");
		}
	}
}
