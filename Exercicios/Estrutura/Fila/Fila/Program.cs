var queue = new Queue<string>();

queue.Enqueue("Eduardo");
queue.Enqueue("Rafael");

var nome = queue.Dequeue();
var nome_1 = queue.Dequeue();
Console.WriteLine(nome);
Console.WriteLine(nome_1);