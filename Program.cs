

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Skapa en instans av KrypteringService
var krypteringService = new Kryptering.KrypteringService();


app.MapGet("/", () => Results.Text("Välkommen till API:et för rövarspråket!\n\n" +
    "För att kryptera ett ord, lägg till \"/encrypt?input=\" och ordet du vill kryptera till URL:n ovan.\n\n" +
    "För att dekryptera ett ord, lägg till \"/decrypt?input=\" och ordet du vill dekryptera till URL:n ovan.", "text/plain", System.Text.Encoding.UTF8));





// Endpoint för kryptering
app.MapGet("/encrypt", (string input) =>
{
     var result = krypteringService.EncryptToRovarspraket(input);
    return Results.Text($"\"{input}\" är lika med: \"{result}\"", "text/plain", System.Text.Encoding.UTF8);
   
})
;

// Endpoint för dekryptering
app.MapGet("/decrypt", (string input) =>
{
    var result = krypteringService.DecryptFromRovarspraket(input);
    return Results.Text($"\"{input}\" är lika med: \"{result}\"", "text/plain", System.Text.Encoding.UTF8);

});

app.Run();


