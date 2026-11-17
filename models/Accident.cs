using System;

public class Accident
{
	private int id;
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

    public Accident(int id, string description, string lieu, DateTime date, Type type, Gravite gravite)
    {
        this.date = date;
        this.description = description;
        this.lieu = lieu;
		this.type = type;
        this.gravite = gravite;
    }
}
