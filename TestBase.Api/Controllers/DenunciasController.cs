using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Api.Models;
using TestBase.Api.Models.Denuncias;

namespace TestBase.Api.Controllers
{
    [Route("api/[controller]")]
    public class DenunciasController : BaseController<Denuncia>
    {
        private readonly IRepository<Denuncia> _repository;
        private readonly ILogger<DenunciasController> _logger;
        private readonly IDenunciaRepository _denunciaRepository;
        private readonly IMapper _mapper;

        public DenunciasController(
            IRepository<Denuncia> repository,
            ILogger<DenunciasController> logger,
            IDenunciaRepository denunciaRepository,
            IMapper mapper) : base(repository, logger)
        {
            _repository = repository;
            _logger = logger;
            _denunciaRepository = denunciaRepository;
            BaseControllerOptions.GetAll = true;
            _mapper = mapper;
        }
    }
}
