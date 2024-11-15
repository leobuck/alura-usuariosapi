using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;

namespace UsuariosApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		[HttpPost]
		public IActionResult CadastraUsuario(CreateUsuarioDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
