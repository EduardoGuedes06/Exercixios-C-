namespace Arquivos;
public class ArquivosClass
{
    public void CriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);
        Console.Write("Informe um nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("----------------------");
        escrever.Close();
    }

    public void LendoArquivo()
    {

        var ler = new StreamReader("Cadastro.txt");
        while(!ler.EndOfStream)
        {
            var linha = ler.ReadLine();
            Console.WriteLine(linha);
        }

        ler.Close();
    }

    public void ExcluindoArquivo()
    {
        if(File.Exists("Cadastro.txt"))
        {
            File.Delete("Cadastro.txt");
        }
    }
}