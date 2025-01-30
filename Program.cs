var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "V�lkommen till API:et f�r r�varspr�ket!");

// Endpoint f�r kryptering
app.MapGet("/encrypt", (string input) =>
{
    return EncryptToRovarspraket(input);
});

// Endpoint f�r dekryptering
app.MapGet("/decrypt", (string input) =>
{
    return DecryptFromRovarspraket(input);
});



//Metod f�r att avkryptera r�varspr�ket
string DecryptFromRovarspraket(string input)
{
    string result = "";
    int i = 0;

    while (i < input.Length)
    {
        result += input[i]; // L�gg alltid till den f�rsta bokstaven

        // Om det �r en konsonant, hoppa �ver "o" och den duplicerade konsonanten
        if (char.IsLetter(input[i]) && (i + 2 < input.Length) && input[i + 1] == 'o' && char.ToLower(input[i]) == char.ToLower(input[i + 2]))
        {
            i += 3; // Hoppa �ver "o" + duplicerad bokstav
        }
        else
        {
            i++; // G� vidare till n�sta tecken
        }
    }
    return result;
}
//Metod f�r kryptering till r�varspr�ket
 string EncryptToRovarspraket(string input)
{
    string vowels = "aeiouy���AEIOUY���";
    string result = "";

    foreach (char c in input)
    {
        if (!vowels.Contains(c) && char.IsLetter(c))
        {
            result += $"{c}o{c.ToString().ToLower()}"; //Om bokstaven �r en konsonant l�gg till "o" och bokstaven en g�ng till
        }
        else
        {
            result += c;
        }
    }
    return result;
}



app.Run();
