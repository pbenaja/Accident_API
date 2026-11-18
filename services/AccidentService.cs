using AccidentAPI.services;
using System;

public class AccidentService:IAccidentService
{
    private readonly List<Accident> accidents = new List<Accident>();

    public Accident Enregistrer(Accident accident)
    {
        accidents.Add(accident);
        return accident;
    }

    public IEnumerable<Accident> GetAll()
    {
        return accidents;
    }
}
