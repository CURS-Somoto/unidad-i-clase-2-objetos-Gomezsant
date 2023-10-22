using System;

class Guerrero
{
    public string nombre;
    public int vida;
    public int nivelAtaque;

    public Guerrero(string nombre, int vida, int nivelAtaque)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.nivelAtaque = nivelAtaque;
    }

    public int Ataque()
    {
        return this.nivelAtaque;
    }

    public void RecibeAtaque(int ataque)
    {
        this.vida -= ataque;
    }
}

class Enfrentamiento
{
    public void Iniciar(Guerrero guerrero1, Guerrero guerrero2)
    {
        Console.WriteLine("Comienza el combate entre {0} y {1}", guerrero1.nombre, guerrero2.nombre);

        while (guerrero1.vida > 0 && guerrero2.vida > 0)
        {
            guerrero2.RecibeAtaque(guerrero1.Ataque());
            Console.WriteLine("{0} ataca a {1} y le hace {2} puntos de daño", guerrero1.nombre, guerrero2.nombre, guerrero1.nivelAtaque);
            Console.WriteLine("{0} tiene {1} puntos de vida restantes", guerrero2.nombre, guerrero2.vida);

            if (guerrero2.vida <= 0) break;

            guerrero1.RecibeAtaque(guerrero2.Ataque());
            Console.WriteLine("{0} ataca a {1} y le hace {2} puntos de daño", guerrero2.nombre, guerrero1.nombre, guerrero2.nivelAtaque);
            Console.WriteLine("{0} tiene {1} puntos de vida restantes", guerrero1.nombre, guerrero1.vida);
        }

        if (guerrero1.vida > 0)
        {
            Console.WriteLine("{0} ha ganado el combate", guerrero1.nombre);
        }
        else
        {
            Console.WriteLine("{0} ha ganado el combate", guerrero2.nombre);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero1 = new Guerrero("Guerrero 1", 100, 10);
        Guerrero guerrero2 = new Guerrero("Guerrero 2", 100, 10);

        Enfrentamiento enfrentamiento = new Enfrentamiento();
        enfrentamiento.Iniciar(guerrero1, guerrero2);
    }
}
