namespace TP1;

public class Equation
{
    private int a, b, c;
    private double delta;
    private double r1, r2;

    public void setA(int a)
    {
        if (a != 0)
        {
            this.a = a;
        }
    }
    
    public int getA()
    {
        return this.a;
    }

    public int B
    {
        get => b;
        set => b = value;
    }

    public int C
    {
        get => c;
        set => c = value;
    }

    public double Delta
    {
        get => delta;
        set => delta = value;
    }

    public double R1
    {
        get => r1;
        set => r1 = value;
    }

    public double R2
    {
        get => r2;
        set => r2 = value;
    }

    public Equation() {}

    public Equation(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void CalculRacine()
    {
        delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0)
        {
            
        }else if (delta == 0)
        {
            r1 = r2 = (-b / 2) * a;
        }
        else
        {
            r1 = (- b + Math.Sqrt(delta)) / (2 * a);
            r2 = (- b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine(delta);
        }
    }

    public override string ToString()
    {
        string result = "";
        if (delta < 0)
        {
            result = $"{this.a}*x^2 + {this.b}*x+{this.c}. Pas de racines réelles";
        }
        result = $"{this.a}*x^2 + {this.b}*x+{this.c}. Racines {this.r1} et {this.r2}";
        return result;
    }
}