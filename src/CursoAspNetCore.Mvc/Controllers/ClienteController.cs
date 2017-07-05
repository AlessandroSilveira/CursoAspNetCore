using Microsoft.AspNetCore.Mvc;
using CursoAspNetCore.Application.Interface.Repository;
using AutoMapper;

namespace CursoAspNetCore.Mvc.Controllers
{

	public class ClienteController : Controller
	{
		private readonly IClienteAppService _clienteaAppService;

		public ClienteController(IClienteAppService clienteaAppService)
		{
			_clienteaAppService = clienteaAppService;
		}

		public IActionResult Index()
		{
			return View(_clienteaAppService.GetAll());
		}
	}
}