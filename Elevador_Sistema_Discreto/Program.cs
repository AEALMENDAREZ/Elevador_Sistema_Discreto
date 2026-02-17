using System;

// Ariel Almendárez - 1074625
// Livi Escobar - 1264425
// Bernardette Aragón - 1265425

class Elevador 
{
    static int capacidadElevador = 10;
    
    static public bool Libre(int numeroPersonas)
    {
        if (numeroPersonas >= capacidadElevador)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    static public string estadoElevador(bool libre) 
    {
        if (libre) 
        {
            return "LIBRE";
        }
        else
        {
            return "OCUPADO";
        }
    }

    static void Main()
    {
        int numeroPersonas = 0;
        Console.WriteLine("El elevador tiene una capacidad de 10 personas...");
        Console.WriteLine("");
        Console.WriteLine("Entran 8 personas al elevador");
        numeroPersonas += 8;
        Console.WriteLine("El elevador se encuentra en estado: " + estadoElevador(Libre(numeroPersonas)));
        Console.WriteLine("");
        Console.WriteLine("Entran 3 personas mas al elevador");
        numeroPersonas += 3;
        Console.WriteLine("El elevador se encuentra en estado: " + estadoElevador(Libre(numeroPersonas)));
    }

}