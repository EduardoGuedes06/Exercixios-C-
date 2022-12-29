namespace date;
public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
        var date2 = DateTime.Parse("2022/12/22 19:25:23");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1 + " , Sintaxe: 2012, 12, 02, 19, 22, 23 ");
        Console.WriteLine(date2 + " , Sintaxe: Parse('2022/12/22 19:25:23'); ");
        Console.WriteLine(date3 + " , Sintaxe: DateTime.Now ");
        Console.WriteLine(date4 + " , Sintaxe: DateTime.Today ");

        Console.Write(date1.ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(" , Sintaxe: formato String: date1.ToString");

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime + " , Sintaxe: formato LocalDateTime");
        Console.WriteLine(dateOffset1.UtcDateTime + " , Sintaxe: formato Utc");
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");

        //var diff = date1 - date2;
        var diff = date1.Subtract(date2);

        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine((int)diff.TotalHours);

    }

    public void AulaAdicionandoDiasMesAno()
    {
        var date1 = DateTime.Now; 

        Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddYears(2).ToString("dd-MM-yyyy HH:mm:ss"));

    }


    public void AulaAdicionandoHoraMinutoSegundos()
    {
        var date1 = DateTime.Now; 

        Console.WriteLine(date1.ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));

    }

    public void AulaDiaDaSemana()
    {
        var date1 = DateTime.Now;  

        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        //var somenteData = new DateOnly(2022,12,2);
        var somenteData =  DateOnly.Parse("2022-02-01");
        
        Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
    }
    
    public void AulaTimeOnly()
    {
        //var outraVariavel = new TimeOnly(12,23,25,0);
        var somenteHora =  TimeOnly.Parse("23:01:23");
        
        Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
    }

}