using CoreEngine.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SqlDatabaseManager.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Gate.Controllers
{

    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ILogger<TicketsController> _logger;
        private readonly ISqlDbManager _sqlDbManager;
        private readonly ICoreEngine _coreEngine;

        public TicketsController(ILogger<TicketsController> logger, ICoreEngine coreEngine)
        {
            _logger = logger;
            _coreEngine = coreEngine;
        }


        //// GET: api/<TicketsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<TicketsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [Route("apiv1/AddTickets")]
        [HttpPost]
        public async Task<IActionResult> AddTickets([FromBody] string value)
        {

            await _coreEngine.AddSettingsAsync(new List<(string, string)>() { ("1", "1"), ("2", "2"), ("3", "3") });


            return StatusCode(403);
        }

    }
}
