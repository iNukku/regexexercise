using System;
using System.Text.RegularExpressions;

//Skriv et eller flere regulære udtræk, der er i stand til at finde danske mobil telefon numre, skrevet hhv. med og uden mellemrum, se ovenfor,  samt med eller uden angivelse af landekode, antaget nævnt i parentes. 

namespace regexexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b(\(\+?45\)\s?)?(\d{2}\s?-?){3}(\d{2})\b");

            string searchstring = "My phoneNumber is 61 12 32 43. Sometimes i write (+45) 61 12 32 43 or even 61123243 or maybe 61-12-32-43";

            foreach (Match match in regex.Matches(searchstring))
            {
                Console.WriteLine("Found the number: {0}. It was located at position: {1}", match.Value, match.Index);
            }
        }
    }
}
