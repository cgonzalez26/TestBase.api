using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models;
using TestBase.Api.Models.Titulares;
using TestBase.Api.Models.Titulares.Dtos;

namespace TestBase.Api.Controllers
{
    [Route("api/[controller]")]

    public class TitularesController : BaseController<Titular>
    {
        private readonly IRepository<Titular> _repository;
        private readonly ILogger<TitularesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ITitularRepository _titularRepository;

        public TitularesController(
            IRepository<Titular> repository,
            ILogger<TitularesController> logger,
            IConfiguration configuration,
            ITitularRepository titularRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _titularRepository = titularRepository;
        }

        [HttpGet, Route("getByNroDocumento/{NroDocumento}")]
        public Titular getByNroDocumento(string NroDocumento)
        {
            return _titularRepository.getByNroDocumento(NroDocumento);
        }

        [HttpGet, Route("deudoresByZona/{ZonaId}")]
        public ICollection<Deudores> deudoresByZona(string ZonaId)
        {
            return _titularRepository.deudoresByZona(ZonaId);
        }
    }
}
