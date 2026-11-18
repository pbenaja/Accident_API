using System;

public class Accident
{
	private Guid id;
    private string description;
    private string lieu;
    public enum TypeAccident
    {
        VOITURE, MOTO
    }
    public enum Gravite
    {
        LEGER, MOYEN, ELEVE
    }
    private DateOnly date;
    private Gravite gravite;
    private TypeAccident type;

    public Accident()
	{
	}

    public Accident( string description, string lieu, DateOnly date, TypeAccident type, Gravite gravite)
    {
        this.Date = date;
        this.Description = description;
        this.Lieu = lieu;
		this.Type1 = type;
        this.Gravite1 = gravite;
        InitialiserId();
    }

    private void InitialiserId()
    {
        this.Id = Guid.NewGuid();
    }

    public override bool Equals(object? obj)
    {
        return obj is Accident accident &&
               Id == accident.Id;
    }

    public string Description { get => description; 
        private set {
            if (value == null) throw new ArgumentNullException("La description est null");
            if (value.Length == 0)
                throw new ArgumentException("la description est vide");
            description = value; 
        }  
    }
    public string Lieu { get => lieu; 
        private set {
            if (value == null) throw new ArgumentNullException("La description est null");
            if (value.Length == 0)
                throw new ArgumentException("le lieu est vide");
            lieu = value;
        }
    }
    public DateOnly Date { get => date;
        private set {
            if (value == null) throw new ArgumentNullException("La date est null");
            date = value;
        } 
    }
    public Gravite Gravite1 { get => gravite;
        private set {
            if (value == null) throw new ArgumentNullException("La gravité est null");
            gravite = value; 
        }  
    }
    public TypeAccident Type1 { get => type;
        private set {
            if (value == null) throw new ArgumentNullException("Le type d'accident est null");
            type = value; 
        }  
    }

    public Guid Id { get => id;private set => id = value; }
}
