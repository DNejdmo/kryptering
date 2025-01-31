﻿namespace Kryptering;


public class KrypteringService
{

    //Metod för att avkryptera rövarspråket
    public string DecryptFromRovarspraket(string input)
    {
        string result = "";
        int i = 0;

        while (i < input.Length)
        {
            result += input[i]; // Lägg alltid till den första bokstaven

            // Om det är en konsonant, hoppa över "o" och den duplicerade konsonanten
            if (char.IsLetter(input[i]) && (i + 2 < input.Length) && input[i + 1] == 'o' && char.ToLower(input[i]) == char.ToLower(input[i + 2]))
            {
                i += 3; // Hoppa över "o" + duplicerad bokstav
            }
            else
            {
                i++; // Gå vidare till nästa tecken
            }
        }
        return result;
    }
    //Metod för kryptering till rövarspråket
    public string EncryptToRovarspraket(string input)
    {
        string vowels = "aeiouyåäöAEIOUYÅÄÖ";
        string result = "";

        foreach (char c in input)
        {
            if (!vowels.Contains(c) && char.IsLetter(c))
            {
                result += $"{c}o{c.ToString().ToLower()}"; //Om bokstaven är en konsonant lägg till "o" och bokstaven en gång till
            }
            else
            {
                result += c;
            }
        }
        return result;
    }

}
