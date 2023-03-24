using BuberDinner.Application.Common.Interface.Authentication;
using BuberDinner.Application.Common.Interfaces.Services;
using BuberDinner.Insfrastructure.Authentication;
using BuberDinner.Insfrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Insfrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInsfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JWTTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DatetimeProvider>();
        return services;
    }
}