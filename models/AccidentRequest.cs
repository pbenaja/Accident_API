using static Accident;

namespace AccidentAPI.models
{
    public record AccidentRequest(string description, string lieu, DateOnly date, TypeAccident type, Gravite gravite)
    {
    }
}
