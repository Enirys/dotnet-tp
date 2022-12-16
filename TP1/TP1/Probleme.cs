namespace TP1;

public class Probleme
{
    static void Main(string[] args)
    {
        Equation monEquation = new Equation(2,3,1);
        monEquation.setA(0);
        monEquation.CalculRacine();
        Console.Write(monEquation.ToString());
    }
}