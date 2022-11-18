using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace backend.Controllers
{
    [Route("api/[Controller]")]
    [Microsoft.AspNetCore.Mvc.ApiController]

    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Player>> GetPlayers()
        {
            return new List<Player>
            {
                new Player
                {
                    Name = "Cristiano Ronaldo",
                    DateOfBirth = "1980-01-01",
                    Team = "Manchester United",
                    Position = "Striker",
                    Nationality = "Portugal"

                },
                new Player {
                    Name = "Lionel Messi",
                    DateOfBirth = "1984-03-01",
                    Team = "PSG",
                    Position = "Striker",
                    Nationality = "Argentina"

                }
            };
        }
    }
}