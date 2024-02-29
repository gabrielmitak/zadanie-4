using System;
using System.Net;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        WebClient client = new WebClient();
        string kursWymianyString = client.DownloadString("https://api.exchangerate-api.com/v4/latest/PLN");

        JObject jsonObj = JObject.Parse(kursWymianyString);
        double kursWymiany = (double)jsonObj["rates"]["USD"];

        Console.Write("Wprowadź kwotę w PLN: ");
        double kwotaPLN = Convert.ToDouble(Console.ReadLine());

        double kwotaUSD = kwotaPLN * kursWymiany;

        Console.WriteLine("Kwota w USD: " + kwotaUSD);
    }
}
