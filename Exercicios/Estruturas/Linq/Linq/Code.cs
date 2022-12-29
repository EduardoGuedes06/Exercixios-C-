namespace Linq
{
    public class LinqEx
    {
        public void Where()
    {

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var resultado = numeros.Where(p => p >= 10);
        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
 
    public void Ordenacao()
    {
        var nomes = new string[] { "Rafael", "Eduardo", "Bruno"};
        var resultado = nomes.OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void Take()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void Count()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.Count(p => p > 10);

        Console.WriteLine(resultado);
    }
    
    public void FirstEFirstOrDefault()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.FirstOrDefault(p => p > 100, -99);
 
        Console.WriteLine(resultado);
    }
    }
}