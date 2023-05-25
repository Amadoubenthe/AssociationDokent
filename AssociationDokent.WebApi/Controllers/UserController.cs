using AssociationDokent.BusinesLogic.Interfaces;
using AssociationDokent.DataAccess.Models;
using Microsoft.AspNetCore.Http;
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
        public async Task<List<User>> Get()
        {
            return await _userService.GetAsync(); 
        }
    }
}
