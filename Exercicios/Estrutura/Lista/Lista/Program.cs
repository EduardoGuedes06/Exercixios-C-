var lista = new List<string>(10);

lista.Add("Rafael");
lista.Add("Pedro");
lista.Add("Antony");

var nome = lista[0];
lista.RemoveAt(0);
Console.WriteLine(nome);

foreach(var item in lista)
{
    Console.WriteLine(item);
}