using System;

public class Accident
{
	private int id;
    private static int nombreAccident=0
    private Guid personneId;
    private string description;
    private string lieu;
    public enum Type
    {
        VOITURE, MOTO
    }
    public enum Gravite
    {
        LEGER, MOYEN, ELEVE
    }
    private DateTime date;
    private Gravite gravite;
    private Type type;

    public Accident()
	{
	}

    public Accident( string description, string lieu, DateTime date, Type type, Gravite gravite)
    {
        nombreAccident++;
        this.date = date;
        this.description = description;
        this.lieu = lieu;
		this.type = type;
        this.gravite = gravite;
        InitialiserId();
    }

    private void InitialiserId()
    {
        this.id = nombreAccident;
    }
    public void InitialiserPersonneId(Guid personneId)
    {
        this.personneId = personneId;
    }
}
