using System.Collections;

var arraylist = new ArrayList();

arraylist.Add(1);
arraylist.Add("Rafael");
arraylist.Add(true);

Console.WriteLine(arraylist[2]);

//arraylist.RemoveAt(1); remove o item
//arraylist.Clear(); Limpa todo o array

foreach(var item in arraylist)
{
    Console.WriteLine(item);
}