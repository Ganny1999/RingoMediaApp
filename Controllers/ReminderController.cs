using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RingoMediaProject.DataContext;
using RingoMediaProject.DomainModel.Models;

namespace RingoMediaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReminderController : ControllerBase
    {
        public readonly AppDbContext _context;
        public ReminderController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult SetRemainder([FromBody] Reminder reminder)
        {
            try
            {
                if(SetRemainder!=null)
                {
                    var isAdded = _context.Reminders.Add(reminder);
                    _context.SaveChanges();

                    var AddedRemainder = _context.Reminders.FirstOrDefault(u=>u.Title.ToLower() == reminder.Title.ToLower());
                    return Ok(AddedRemainder);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
