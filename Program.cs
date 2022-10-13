class Converter
{


    private decimal dollar;        //p
    private decimal euro;

    public Converter(decimal dol, decimal eur) //к
    {
        dollar = dol;
        euro = eur;
    }

    public decimal HrnToEuro(decimal hrn) //m
    {
        return hrn / euro;
    }


    public decimal HrnToDollar(decimal hrn)
    {
        return hrn / dollar;
    }

    public decimal EuroToHrn(decimal hrn)
    {
        return hrn * euro;
    }


    public decimal DollarToHrn(decimal hrn)
    {
        return hrn * dollar;
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        var converter = new Converter(42, 39);
        Console.WriteLine("Введіть сумму в грн: ");
        decimal hrnAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Виберіть дію: ");
        Console.WriteLine("1- гривні в євро:");
        Console.WriteLine("2- гривні в доллар : ");
        Console.WriteLine("3- євро в гривні: ");
        Console.WriteLine("4- доллари в гривні: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {

            case 1:
                
                Console.WriteLine(converter.HrnToEuro(hrnAmount));
                    break;
            
            case 2:
  
                Console.WriteLine(converter.HrnToDollar(hrnAmount));
                    break;
            
            case 3:
                
                Console.WriteLine(converter.EuroToHrn(hrnAmount));
                    break;
            
            case 4:
                
                Console.WriteLine(converter.DollarToHrn(hrnAmount));
                    break;

        }
    }
}