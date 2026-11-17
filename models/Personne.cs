using System;

public class Personne
{
	private Guid id;
	private string prenom;
	private string nom;
	private int age;
	public enum Sexe
	{
		MASCULIN,FEMININ
	}
	private Sexe genre;

    
    public Personne()
	{
	}
	public Personne(Guid id,string prenom, string nom, int age, Sexe genre)
	{
		this.Id = id;
		this.Prenom = prenom;
		this.Nom = nom;
		this.Age = age;
		this.genre = genre;
	}

    public override bool Equals(object? obj)
    {
		return obj is Personne personne &&
			   id.Equals(personne.id);
    }
    public Guid Id { get => id; private set => id = value; }
    public string Prenom
    {
        get => prenom;
        private set
        {
            if (value is null)
                throw new ArgumentNullException("le prenom est null");
            if (value.Length == 0)
                throw new ArgumentException("le prenom est vide");
            if (value.Length > 20)
                throw new ArgumentException("veuillez saisir votre prénom ou ses 20 premiers caractères");
            prenom = value;
        }
    }
    public string Nom
    {
        get => nom;
        private set
        {
            if (value is null)
                throw new ArgumentNullException("le nom est null");
            if (value.Length == 0)
                throw new ArgumentException("le prenom est vide");
            if (value.Length > 20)
                throw new ArgumentException("veuillez saisir votre nom ou ses 20 premiers caractères");
            nom = value;
        }
    }
    public int Age
    {
        get => age;
        private set
        {
            if (value < 0) throw new ArgumentException("l'âge doit être supérieur à 0");
            age = value;
        }
    }

}
