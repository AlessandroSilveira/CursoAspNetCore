using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CursoAspNetCore.Mvc.Models;
using CursoAspNetCore.Application.Interface.Repository;

namespace CursoAspNetCore.Mvc.Controllers {

    public class ClienteController : Controller {

        private readonly IClienteAppService _clienteaAppService;

        public ClienteController (IClienteAppService clienteaAppService) {
            _clienteaAppService = clienteaAppService;
        }

        public IActionResult Index () {
            return View (_clienteaAppService.GetAll());
        }
    }
}