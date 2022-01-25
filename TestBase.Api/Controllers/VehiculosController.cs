using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models;
using TestBase.Api.Models.Vehiculos;

namespace TestBase.Api.Controllers
{
    [Route("api/[controller]")]

    public class VehiculosController : BaseController<Vehiculo>
    {
        private readonly IRepository<Vehiculo> _repository;
        private readonly ILogger<VehiculosController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IVehiculoRepository _vehiculoRepository;

        public VehiculosController(
            IRepository<Vehiculo> repository,
            ILogger<VehiculosController> logger,
            IConfiguration configuration,
            IVehiculoRepository vehiculoRepository) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
            _vehiculoRepository = vehiculoRepository;
        }
    }
}
