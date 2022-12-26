var Dicionario = new Dictionary<int,string>();
Dicionario.Add(100,"Rafael");
Dicionario[50]="Curso";
var nome = Dicionario[50];

Console.WriteLine(nome);

var Pablo = new Dictionary<string,string>()
{
    {"Teste 1 de 1","Teste 2 de 1"},
    {"Teste 1 de 2","Teste 2 de 2"},
};

foreach( var item in Dicionario)
{
    Console.WriteLine(item);
}

foreach( var item in Pablo)
{
    Console.WriteLine(item.Key);
}