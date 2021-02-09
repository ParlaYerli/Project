using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("getall")]
        public List<User> GetList()
        {
            return _service.GetList();
        }

        [HttpGet("getbyid/{userId}")]
        public User GetArticleById(int userId)
        {
            return _service.GetById(userId);
        }
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            _service.Add(user);
            return Ok();
        }

        [HttpDelete("{userId}")]
        public IActionResult Delete(int userId)
        {
            User user = _service.GetById(userId);
            _service.Delete(user);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(User user)
        {
            _service.Update(user);
            return Ok();
        }

    }
}
