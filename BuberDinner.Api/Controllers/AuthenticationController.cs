using BuberDinner.Application.Services.Authentication;
using BumberDiner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BumberDiner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var response = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        var mapToResponse = new AuthenticationResponse(
            response.Id,
            response.FirstName,
            response.LastName,
            response.Email,
            response.Token
        );
        return Ok(mapToResponse);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var response = _authenticationService.Login(request.Email, request.Password);
        var mapToResponse = new AuthenticationResponse(
            response.Id,
            response.FirstName,
            response.LastName,
            response.Email,
            response.Token
        );
        return Ok(mapToResponse);
    }
}