using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models;
using TestBase.Api.Models.ImpuestosAut;
using TestBase.Api.Models.ImpuestosAut.Dtos;

namespace TestBase.Api.Controllers
{
    [Route("api/[controller]")]
    public class ImpuestosAutController : BaseController<ImpuestoAut>
    {
        private readonly IRepository<ImpuestoAut> _repository;
        private readonly ILogger<ImpuestosAutController> _logger;
        private readonly IImpuestoAutRepository _impuestos_autRepository;
        private readonly IMapper _mapper;

        public ImpuestosAutController(
            IRepository<ImpuestoAut> repository,
            ILogger<ImpuestosAutController> logger,
            IImpuestoAutRepository impuestos_autRepository,
            IMapper mapper) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _impuestos_autRepository = impuestos_autRepository;
            BaseControllerOptions.GetAll = true;
            _mapper = mapper;
        }

        [HttpGet, Route("NroDocumento/{NroDocumento}")]
        public ICollection<ImpuestoAutWebDto> getByNroDocumento(string NroDocumento) 
        {
            return _impuestos_autRepository.getByNroDocumento(NroDocumento);
        }
    }
}
