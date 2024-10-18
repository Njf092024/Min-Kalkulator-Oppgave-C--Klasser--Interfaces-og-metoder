// class Class : Interface -> means "implements" in this case
public class Calculator : ICalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;   
    }
    
}