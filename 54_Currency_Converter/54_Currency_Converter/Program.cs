using System;

class CurrencyConverter
{
    private double exchangeRate;

    public CurrencyConverter(double exchangeRate)
    {
        this.exchangeRate = exchangeRate;
    }

    public double ConvertToUSD(double amount)
    {
        return amount / exchangeRate;
    }

    public double ConvertFromUSD(double amount)
    {
        return amount * exchangeRate;
    }
}

class Program
{
    static void Main()
    {
        // Create a currency converter with an exchange rate of 107.20 (1 USD = 107.20 BDT)
        CurrencyConverter converter = new CurrencyConverter(107.20);

        Console.WriteLine("Enter amount in USD: ");
        double usdAmount = Convert.ToDouble(Console.ReadLine());

        double convertedAmount = converter.ConvertFromUSD(usdAmount);

        Console.WriteLine("Converted amount: " + convertedAmount + " BDT");

        Console.ReadLine();
    }
}
