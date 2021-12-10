using System.Threading.Tasks;
using TestBase.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestBase.Api.Controllers
{
    //[Authorize("AtiIdentityServer4Policy")]
    [Authorize("AtiIdentityServer4Policy", AuthenticationSchemes = "Bearer")]
    //[Authorize]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : Models.Base, new()
    {
        public readonly IRepository<T> Repository;
        public readonly ILogger<BaseController<T>> Logger;
        public readonly BaseControllerOptions BaseControllerOptions;
        const string bc403 = "BC403: Acción prohibida por las opciones del controlador base. Configure la opción correspondiente en su controlador.";

        protected BaseController(
            IRepository<T> repository,
            ILogger<BaseController<T>> logger,
            BaseControllerOptions baseControllerOptions = null)
        {
            Repository = repository;
            Logger = logger;
            if (baseControllerOptions == null)
            {
                BaseControllerOptions = new BaseControllerOptions();
            }
        }

        [HttpGet, Route("all")]
        public IActionResult GetAll()
        {
            if (!BaseControllerOptions.GetAll) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            return Ok(Repository.GetAll());
        }

        [HttpGet, Route("async/all")]
        public async Task<IActionResult> GetAllAsync()
        {
            if (!BaseControllerOptions.GetAllAsync) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            return Ok(await Repository.GetAllAsync());
        }

        [HttpGet, Route("id/{id}")]
        public IActionResult GetById(string id)
        {
            if (!BaseControllerOptions.GetById) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            return Ok(Repository.GetById(id));
        }

        [HttpGet, Route("async/id/{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            if (!BaseControllerOptions.GetByIdAsync) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            return Ok(await Repository.GetByIdAsync(id));
        }

        [HttpGet, Route("count")]
        public IActionResult Count()
        {
            if (!BaseControllerOptions.Count) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            return Ok(Repository.Count(null));
        }

        [HttpGet, Route("async/count")]
        public async Task<IActionResult> CountAsync()
        {
            if (!BaseControllerOptions.CountAsync) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            return Ok(await Repository.CountAsync(null));
        }

        [HttpPost, Route("add")]
        public IActionResult InsertAndSave([FromBody] T value)
        {
            if (!BaseControllerOptions.InsertAndSave) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            Repository.InsertAndSave(value);
            return Ok();
        }

        [HttpPost, Route("async/add")]
        public async Task<IActionResult> InsertAndSaveAsync([FromBody] T value)
        {
            if (!BaseControllerOptions.InsertAndSaveAsync) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            await Repository.InsertAndSaveAsync(value);
            return Ok();
        }

        [HttpPut, Route("edit/{id}")]
        public IActionResult UpdateAndSave(string id, [FromBody] T value)
        {
            if (!BaseControllerOptions.UpdateAndSave) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            Repository.UpdateAndSave(value);
            return Ok();
        }

        [HttpPut, Route("async/edit/{id}")]
        public async Task<IActionResult> UpdateAndSaveAsync(string id, [FromBody] T value)
        {
            if (!BaseControllerOptions.UpdateAndSaveAsync) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            await Repository.UpdateAndSaveAsync(value);
            return Ok();
        }

        [HttpDelete, Route("delete/{id}")]
        public IActionResult DeleteByIdAndSave(string id)
        {
            if (!BaseControllerOptions.DeleteByIdAndSave) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            Repository.DeleteByIdAndSave(id);
            return Ok();
        }

        [HttpDelete, Route("async/delete/{id}")]
        public async Task<IActionResult> DeleteByIdAndSaveAsync(string id)
        {
            if (!BaseControllerOptions.DeleteByIdAndSaveAsync) return StatusCode(StatusCodes.Status403Forbidden, bc403);
            await Repository.DeleteByIdAndSaveAsync(id);
            return Ok();
        }
    }

    public class BaseControllerOptions
    {
        public bool GetAll { get; set; } = false;
        public bool GetAllAsync { get; set; } = false;
        public bool GetById { get; set; } = false;
        public bool GetByIdAsync { get; set; } = false;
        public bool Count { get; set; } = false;
        public bool CountAsync { get; set; } = false;
        public bool InsertAndSave { get; set; } = false;
        public bool InsertAndSaveAsync { get; set; } = false;
        public bool UpdateAndSave { get; set; } = false;
        public bool UpdateAndSaveAsync { get; set; } = false;
        public bool DeleteByIdAndSave { get; set; } = false;
        public bool DeleteByIdAndSaveAsync { get; set; } = false;
    }
}
