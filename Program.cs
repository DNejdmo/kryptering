

    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    // Skapa en instans av KrypteringService
    var krypteringService = new Kryptering.KrypteringService();

    app.MapGet("/", () => "Välkommen till API:et för rövarspråket!");

    // Endpoint för kryptering
    app.MapGet("/encrypt", (string input) =>
    {
        return krypteringService.EncryptToRovarspraket(input);
})
;

// Endpoint för dekryptering
app.MapGet("/decrypt", (string input) =>
{
    return krypteringService.DecryptFromRovarspraket(input);
});

app.Run();
