using AssociationDokent.BusinesLogic.Interfaces;
using AssociationDokent.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;


namespace AssociationDokent.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userService;
        
        public UserController(IUser userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return Ok(await _userService.GetSimplifyAsync(cancellationToken, null));
        }

        [HttpGet("gender")]
        public async Task<IActionResult> GetUsersByGender([FromQuery] string gender, CancellationToken cancellationToken)
        {
            return Ok(await _userService.GetSimplifyAsync(cancellationToken, gender)) ;
        }

    }
}
