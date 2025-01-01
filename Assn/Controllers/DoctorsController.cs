using Assn.Dtos.DoctorDtos;
using Assn.Repos.DoctorsRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorsRepo _repo;
        public DoctorsController(IDoctorsRepo repo)
        {
            _repo = repo;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }
        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            return Ok(_repo.GetById(id));
        }
        [HttpPost]
        public IActionResult AddAll(GetDoctorsAll dto)
        {
            _repo.AddAll(dto);
            return Accepted();
        }
        [HttpPut]
        public IActionResult Update(GetDoctorsAll dto, int id)
        {
            _repo.Update(dto, id);
            return Accepted();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return NoContent();
        }
    }
}
