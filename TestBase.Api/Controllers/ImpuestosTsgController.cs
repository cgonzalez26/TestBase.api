using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models;
using TestBase.Api.Models.ImpuestosTsg;

namespace TestBase.Api.Controllers
{
    [Route("api/[controller]")]
    public class ImpuestosTsgController : BaseController<ImpuestoTsg>
    {
        private readonly IRepository<ImpuestoTsg> _repository;
        private readonly ILogger<ImpuestosTsgController> _logger;
        private readonly IImpuestoTsgRepository _impuestos_tsgRepository;
        private readonly IMapper _mapper;

        public ImpuestosTsgController(
            IRepository<ImpuestoTsg> repository,
            ILogger<ImpuestosTsgController> logger,
            IImpuestoTsgRepository impuestos_tsgRepository,
            IMapper mapper) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _impuestos_tsgRepository = impuestos_tsgRepository;
            BaseControllerOptions.GetAll = true;
            _mapper = mapper;
        }
    }
}
