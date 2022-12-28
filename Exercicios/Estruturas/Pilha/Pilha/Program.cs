var stack = new Stack<string>();

stack.Push("Eduardo");
stack.Push("Pablo");


var nome = stack.Pop();
var nome_1 = stack.Pop();

Console.WriteLine(nome);
Console.WriteLine(nome_1);


foreach( var item in stack)
{
    Console.WriteLine(item);
}