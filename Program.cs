using System;
using System.IO;

class Program
{
    static void Main()
    {
        string dateiPfad = "main.crx";

        try
        {
            // Lesen des gesamten Inhalts der Datei als String
            string inhalt = File.ReadAllText(dateiPfad);
            Console.WriteLine(inhalt);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Lesen der Datei: {ex.Message}");
        }
    }
}
