using System.Collections;
using System.Collections.Generic;

class Universidad
{
    public string nombre { get; set; }
    public int aceptar { get; set; }
    public int rechazar { get; set; }
    public int nulos { get; set; }
    public int votos { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Universidad> universidades = new List<Universidad>();
        Console.Clear();
        Console.WriteLine("Cantidad de Universidades que participan: ");
        int count = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Clear();
            Console.WriteLine("Nombre de la Universidad: ");
            string nombre = Console.ReadLine();
            Universidad uni = new Universidad { nombre = nombre };

            while (true)
            {
                Console.WriteLine("Voto: aceptar (A), rechazar (R), nulo (N) o blanco (B), terminar (X)");
                string vote = Console.ReadLine().ToUpper();
                if (vote == "A") uni.aceptar++;
                else if (vote == "R") uni.rechazar++;
                else if (vote == "N") uni.nulos++;
                else if (vote == "B") uni.votos++;
                else if (vote == "X") break;
            }

            universidades.Add(uni);
        }
        Console.Clear();
        foreach (var uni in universidades)
        {

            Console.WriteLine($"Universidad: {uni.nombre}, Aceptar: {uni.aceptar}, Rechazar: {uni.rechazar}, Nulo: {uni.nulos}, Blanco: {uni.votos}");
        }

        int accept = universidades.Count(u => u.aceptar > u.rechazar);
        int reject = universidades.Count(u => u.rechazar > u.aceptar);
        int tie = universidades.Count(u => u.aceptar == u.rechazar);

        Console.WriteLine($"Universidades que Aceptan: {accept}, Universidades que Rechazan: {reject}, Universidades que Empata: {tie}");
    }
}