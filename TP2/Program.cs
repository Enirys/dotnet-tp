using TP2;

public class Program
{
    /*static void Main(string[] args)
    {
        int age = 0;
        Console.WriteLine("Quel âge avez-vous?");
        try
        {
            age = int.Parse(Console.ReadLine());
        }
        catch(Exception e) {
            Console.WriteLine("Veuillez entrer un nombre entier.");
            // Console.WriteLine(e.ToString());
        }
        Console.WriteLine("Vous avez " + age + " ans!");
        Console.ReadLine();
    }*/

    static void Main(string[] args)
    {
        uint a = 0;
        uint b = 0;
        uint c = 0;

        Console.WriteLine("Nous allons faire une division avec des nombres positifs: ");
        Console.Write("\nEntrez un premier nombre : ");

        try
        {
            a = uint.Parse(Console.ReadLine());
        }
        catch(FormatException fEx)
        {
            Console.Write("Veuillez entrer un entier.");
        }
        catch (OverflowException ofEx)
        {
            Console.Write("Veuillez entrer un entier positif.");
        }

        Console.Write("Entrez un deuxieme nombre : ");

        try
        {
            b = uint.Parse(Console.ReadLine());
        }
        catch (FormatException fEx)
        {
            Console.Write("Veuillez entrer un entier.");
        }
        catch (OverflowException ofEx)
        {
            Console.Write("Veuillez entrer un entier positif.");
        }
        try
        {
            c = a / b;
        }
        catch(DivideByZeroException zEx)
        {
            Console.Write("Vous essayez de faire une division par 0.");
        }

        Console.WriteLine("Le résultat de la division est " + c);
        Console.ReadLine();
    }

    /*static void Main(string[] args)
    {
        Brique brique = new Brique(new Point3D(10.0,4.0,3.0), 10.5, 14.3, 4.6);
        Cube cube = new Cube(new Point3D(10.0,4.0,3.0), 5.0, 5.0, 5.0);
        Boule boule1 = new Boule(new Point3D(10.0,4.0,3.0), 5.0);
        Boule boule2 = new Boule(new Point3D(10.0,4.0,3.0), 5.0);
        
        Console.WriteLine(brique.ToString());
        Console.WriteLine("Surface: " + brique.CalculerSurface());
        Console.WriteLine("Volume: " + brique.CalculerVolume());

        Console.WriteLine(cube.ToString());
        Console.WriteLine("Surface: " + cube.CalculerSurface());
        Console.WriteLine("Volume: " + cube.CalculerVolume());

        Console.WriteLine(boule1.ToString());
        Console.WriteLine("Surface: " + boule1.CalculerSurface());
        Console.WriteLine("Volume: " + boule1.CalculerVolume());

        Console.WriteLine(boule2.ToString());
        Console.WriteLine("Surface: " + boule2.CalculerSurface());
        Console.WriteLine("Volume: " + boule2.CalculerVolume());

        Console.WriteLine(boule1.Egale(boule2) ? "Sont egales" : "Ne sont pas egales");

    }*/
}