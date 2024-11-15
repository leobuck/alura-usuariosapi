using Microsoft.AspNetCore.Mvc;

namespace UsuariosApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		[HttpPost]
		public IActionResult CadastraUsuario()
		{
			throw new NotImplementedException();
		}
	}
}
