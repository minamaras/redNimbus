﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedNimbus.API.Services.Interfaces;
using RedNimbus.DTO;
using RedNimbus.Either;
using RedNimbus.Either.Errors;

namespace RedNimbus.API.Controllers
{
    [ApiController]
    [Route("api/v2/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #region IActionResult

        private IActionResult AllOk()
        {
            return Ok(new Empty());
        }

        private IActionResult AllOk(object obj)
        {
            return Ok(obj);
        }

        private IActionResult BadRequestErrorHandler(IError error)
        {
            return BadRequest(error.Message);
        }

        private IActionResult InternalServisErrorHandler(IError error)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, error.Message);
        }

        private IActionResult NotFoundErrorHandler(IError error)
        {
            return NotFound(error.Message);
        }

        private IActionResult AuthenticationErrorHandler(IError error)
        {
            return StatusCode(StatusCodes.Status406NotAcceptable, error.Message);
        }

        #endregion

        [HttpPost]
        public IActionResult Post([FromBody]CreateUserDto createUserDto)
        {
            return _userService.RegisterUser<CreateUserDto, Empty>(createUserDto)
                 .Map(() => AllOk())
                 .Reduce(BadRequestErrorHandler, x => x is FormatError)
                 .Reduce(InternalServisErrorHandler);

        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateUserDto userLoginDTO)
        {
            return _userService.AuthenticateUser<AuthenticateUserDto, UserDto>(userLoginDTO)
                .Map(x => AllOk(x))
                .Reduce(AuthenticationErrorHandler, err => err is AuthenticationError)
                .Reduce(InternalServisErrorHandler);
        }
        

        // TODO: GET
    }
}