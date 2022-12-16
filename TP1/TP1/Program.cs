class Program
{
    /*static void Main(string[] args)
    {
        Personne p = new Personne("Khelifi", "syrine", 24, 56580541);
        Console.WriteLine(p.nom);
    }*/
}

class Personne
{
    public string nom;
    public string prenom;
    public int age;
    public int telephone;
    
    Personne() {}
    
    public Personne(string nom, string prenom, int age, int telephone)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.age = age;
        this.telephone = telephone;
    }
    
    public Personne(Personne p)
    {
        this.nom = p.nom;
        this.prenom = p.prenom;
        this.age = p.age;
        this.telephone = p.telephone;
    }
}