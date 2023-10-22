using System;

class Punto
{
    private double x;
    private double y;

    public Punto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double MedirDistancia()
    {
        // Calcula la distancia entre el punto actual y el origen (0,0) usando el teorema de Pitágoras.
        double distancia = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distancia;
    }
}

class Program
{
    static void Main()
    {
        Punto punto1 = new Punto(3, 4); // Crear un punto en (3, 4)
        double distanciaAlOrigen = punto1.MedirDistancia();
        Console.WriteLine($"La distancia al origen es: {distanciaAlOrigen}");
    }
}
