using GrokkingAlgorithms.Api.Dtos;
using GrokkingAlgorithms.DataAccess.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmResultsController : ControllerBase
    {
        private readonly IAlgorithmResultRepository _algorithmResultRepository;

        public AlgorithmResultsController(IAlgorithmResultRepository algorithmResultRepository)
        {
            _algorithmResultRepository = algorithmResultRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetResults()
        {
            return Ok(await _algorithmResultRepository.GetResults());
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetResults(int Id)
        {
            var result = await _algorithmResultRepository.GetResult(Id);

            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddResult([FromBody]AlgorithmResultRequest dto)
        {
            var entity = dto.ToEntity();
            var response = await _algorithmResultRepository.AddResult(entity);

            if (response == true)
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete]
        [Route("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteResult(int Id)
        {
            var response = await _algorithmResultRepository.DeleteResult(Id);

            if (response == true)
                return Ok();
            else
                return BadRequest();
        }
    }
}
