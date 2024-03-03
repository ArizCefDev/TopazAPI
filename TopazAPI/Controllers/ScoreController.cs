using Business.Abstract;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TopazAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreService _scoreService;

        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        [HttpGet]
        public IActionResult ScoreList()
        {
            var values = _scoreService.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult ScoreID(int id)
        {
            var values = _scoreService.GetById(id);
            return Ok(values);
        }


        [HttpPost]
        public IActionResult ScoreAdd(ScoreDTO s)
        {
            string answer = "Success insert";

            s.Date = DateTime.Now;
            _scoreService.Insert(s);
            return Ok(answer);
        }

        [HttpPut]
        public IActionResult ScoreUpdate(ScoreDTO s)
        {
            string answer = "Success update";
            s.Date = DateTime.Now;
            _scoreService.Update(s);
            return Ok(answer);
        }

        [HttpDelete("{id}")]
        public IActionResult ScoreDelete(int id)
        {
            string answer = "Success delete";
            _scoreService.Delete(id);
            return Ok(answer);
        }
    }
}
