using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction  fraction1 = new Fraction ();
        Fraction  fraction2 = new Fraction(6);
        Fraction  fraction3 = new Fraction(6,7);
        
        string    fraction1String = fraction1.GetFractionString();
        double    fraction1Decimal = fraction1.GetDecimalValue();



        string    fraction2String =  fraction2.GetFractionString();
        double    fraction2Decimal = fraction2.GetDecimalValue();

       string     fraction3String = fraction3.GetFractionString();
       double     fraction3Decimal = fraction3.GetDecimalValue();

        Console.WriteLine($"{fraction1String}");
        Console.WriteLine($"{fraction1Decimal}");

        Console.WriteLine($"{fraction2String}");
        Console.WriteLine($"{fraction2Decimal}");

        Console.WriteLine($"{fraction3String}");
        Console.WriteLine($"{fraction3Decimal}");
    }
}