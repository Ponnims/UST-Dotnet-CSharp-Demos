using LearnerAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnerController : ControllerBase
    {

        private readonly LearnerDbContext context;
        public LearnerController(LearnerDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetLearners()
        {
            var learners = context.Tbl_Learner.ToList();
            return Ok(learners);
        }

        [HttpPost]
        public IActionResult AddLearner([FromBody] Learner learner)
        {
            if (ModelState.IsValid)
            {
                context.Tbl_Learner.Add(learner);
                context.SaveChanges();
                return Ok(learner);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLearner(int id, [FromBody] Learner learner)
        {
            if (id != learner.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                context.Tbl_Learner.Update(learner);
                context.SaveChanges();
                return Ok(learner);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLearner(int id)
        {
            var learner = context.Tbl_Learner.Find(id);
            if (learner == null)
            {
                return NotFound();
            }

            context.Tbl_Learner.Remove(learner);
            context.SaveChanges();
            return NoContent();
        }
    }
}
