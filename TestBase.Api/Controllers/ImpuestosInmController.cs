using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models;
using TestBase.Api.Models.ImpuestosInm;

namespace TestBase.Api.Controllers
{
    [Route("api/[controller]")]
    public class ImpuestosInmController : BaseController<ImpuestoInm>
    {
        private readonly IRepository<ImpuestoInm> _repository;
        private readonly ILogger<ImpuestosInmController> _logger;
        private readonly IImpuestoInmRepository _impuestos_inmRepository;
        private readonly IMapper _mapper;

        public ImpuestosInmController(
            IRepository<ImpuestoInm> repository,
            ILogger<ImpuestosInmController> logger,
            IImpuestoInmRepository impuestos_inmRepository,
            IMapper mapper) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _impuestos_inmRepository = impuestos_inmRepository;
            BaseControllerOptions.GetAll = true;
            _mapper = mapper;
        }
    }
}
