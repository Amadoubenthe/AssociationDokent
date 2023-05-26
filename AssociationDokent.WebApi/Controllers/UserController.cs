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
        public async Task<List<UserSimplify>> Get()
        {
            return await _userService.GetSimplifyAsync();
        }

        [HttpGet("gender")]
        public async Task<List<UserSimplify>> GetUsersByGender([FromQuery] string gender)
        {
            return await _userService.GetSimplifyAsync(gender);
        }

    }
}
