using BuberDinner.Application.Common.Interface.Authentication;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string Email, string Password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "FirstName", "LastName", Email, "token");
    }

    public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
    {
        // Check if user already exists

        // Create user(gen unique Id)

        //Create JWT token
        Guid id = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(id, FirstName, LastName);
        return new AuthenticationResult(id, FirstName, LastName, Email, token);
    }
}