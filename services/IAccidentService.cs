namespace AccidentAPI.services
{
    public interface IAccidentService
    {
        IEnumerable<Accident> GetAll();
        Accident Enregistrer(Accident accident);
    }
}
