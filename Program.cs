

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Skapa en instans av KrypteringService
var krypteringService = new Kryptering.KrypteringService();

app.MapGet("/", () => Results.Json(new { message = "V�lkommen till API:et f�r r�varspr�ket!" }));

// Endpoint f�r kryptering
app.MapGet("/encrypt", (string input) =>
{
    return krypteringService.EncryptToRovarspraket(input);
})
;

// Endpoint f�r dekryptering
app.MapGet("/decrypt", (string input) =>
{
    return krypteringService.DecryptFromRovarspraket(input);
});

app.Run();


