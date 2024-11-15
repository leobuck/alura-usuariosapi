using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuariosApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class AcessoController : ControllerBase
	{
		[HttpGet]
		[Authorize(Policy = "IdadeMinima")]
		public IActionResult Get()
		{
			return Ok("Acesso permitido!");
		}
	}
}
