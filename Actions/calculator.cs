using System.Security.Cryptography.X509Certificates;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Divide(int a, int b)
    {

    if (b == 0)
    {
        throw new ArgumentException("Kan inte vara 0.", nameof(b));
    }
    
    return (double) a / b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}