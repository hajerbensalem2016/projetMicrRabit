using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilialeController: ControllerBase
    {
        private readonly IFilialeService _filialeService;

        public FilialeController(IFilialeService filialeService)
        {
            _filialeService = filialeService;
        }

        // GET api/Filiale
        [HttpGet]
        public ActionResult<IEnumerable<Filiale>> Get()
        {
            return Ok(_filialeService.GetFiliales());
        }

    }
}
