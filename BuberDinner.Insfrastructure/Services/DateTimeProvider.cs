using BuberDinner.Application.Common.Interfaces.Services;

namespace BuberDinner.Insfrastructure.Services;

public class DatetimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}