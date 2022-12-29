namespace workstrings;
public class Strings
{
    public void StringToLower()
    {
        Console.Write("Teste string to Lower: ");
        var linha = Console.ReadLine();
        linha = linha.ToLower();
        Console.WriteLine("To lower: "+linha);
    }

        public void StringToUper()
    {
        Console.Write("Teste string to Uper: ");
        var linha = Console.ReadLine();
        linha = linha.ToUpper();
        Console.WriteLine("To Uper: "+linha);
    }
         public void StringToSub()
    {
        Console.Write("Teste de Sub string: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(8));
    }

        public void StringRange()
    {
        string nomeArquivo = "2022_12_29_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);

        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }
        public void StringContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak"; 
        if(nomeArquivo.Contains("backup_teste"))
        {
            Console.WriteLine("Palavra encontrada");
        }
        else
        {
            Console.WriteLine("Palavra nao encontrada");
        }
        Console.WriteLine("Contem nome backup :" + nomeArquivo.Contains("backup"));
    }
    public void StringTrim()
    {
        string teste = "**Eduardo Guedes**"; 
        
        Console.WriteLine("TOTAL: " + teste.Trim('*'));
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));
        Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
    }
    public void StringStartWithEndsWith()
    {
        string teste = "Eduardo Guedes"; 
        
        Console.WriteLine("INICIO: " + teste.StartsWith("Rafael"));
        Console.WriteLine("FINAL: " + teste.EndsWith("Guedes"));
    }

    public void StringReplace()
    {
        string teste = "Eduardo Guedes";  
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Guedes", "Guedes Pereira"));
        Console.WriteLine(teste.Replace("Guedes", "Caminhões"));
    }

    public void StringLength()
    {
        Console.Write("String Teste: ");
        string teste = Console.ReadLine(); 
        int count = teste.Length;
        Console.WriteLine("A string teste :" + teste + ". possui " + count + " letras");
    }
}

