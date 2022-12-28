var arrayTiponumero = new int[3];
arrayTiponumero[0] = 10;
arrayTiponumero[1] = 15;
arrayTiponumero[2] = 20;

Array.Resize(ref arrayTiponumero, 100);
arrayTiponumero[10] = 200;

foreach(var item in arrayTiponumero)
{
    Console.WriteLine(item);
}

var arrayTostring = new string[2] {"Pablo","Fabricio"};

foreach(var item in arrayTostring)
{
    Console.WriteLine(item);
}