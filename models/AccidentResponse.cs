using static Accident;

namespace AccidentAPI.models
{
    public record AccidentResponse(string description, string lieu, DateOnly date, TypeAccident type, Gravite gravite)
    {
    }
}
