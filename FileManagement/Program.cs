using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        string[] testInput = { "Arta", "Angelica", "Albert", "Benjamin", "Mitchel", "Dafina", "Aleksandar","Olof" };


        List<string> filtreralistan = SortsListStartingWithA(testInput);


        foreach (string item in filtreralistan)
        {
            Console.WriteLine(item);
        }

        FilteredListFile(filtreralistan);

    }

    static List<string> SortsListStartingWithA(string[] testInput)
    {
        List<string> filtreralistan = new List<string>();

        foreach (string item in testInput)
        {
            if (item.StartsWith("A") || item.StartsWith("a"))
            {
                filtreralistan.Add(item);
            }
        }

        return filtreralistan;
    }
    static void FilteredListFile(List<string> filtreralistan)
    {

        string DocumentPath = @"C:\Users\Dafii\OneDrive\Dokument\FileManagement";


        if (!Directory.Exists(DocumentPath))
        {
            Directory.CreateDirectory(DocumentPath);
        }


        string pathToFile = Path.Combine(DocumentPath, "TheResult.txt");


        using (StreamWriter writer = new StreamWriter(pathToFile))
        {
            foreach (string item in filtreralistan)
            {
                writer.WriteLine(item);
            }
        }

        Console.WriteLine("The list has been filtered.");

    }
}
//Hur kan du vidare utveckla koden så att 
//den utför samma arbete för varje lista med element som börjar med specifik bokstav i 
//alfabetet. ( katalog D, filen med tex. Dan, Daniela, Dario, Dusan…) 


//Svar:
//Prompt the user to enter a letter by which you want to filter, save the input to a variable,
//then use this variable as a parameter in the SortsListStartingWithA and FilteredListFile methods, aswell as in the if statement in the foreach loop.
//Then we have to make the filePath more dynamic, so that it doesn't keep overwriting the same files but makes a file for each different letter we filter by

