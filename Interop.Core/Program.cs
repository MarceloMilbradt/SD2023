using System.Net.Http.Json;

HttpClient httpClient = new HttpClient();
Mensagem mensagem;

if (args.Length > 0)
{
    var conteudo = args[0];
    mensagem = new Mensagem(DateTime.Now, conteudo, Guid.NewGuid());
}
else
{
    mensagem = new Mensagem(DateTime.Now, "Nenhuma Mensagem!", Guid.NewGuid());
}
var defaultColor = Console.ForegroundColor;
Console.WriteLine("Enviando Mensagem ao firebase!");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(mensagem);

var response = await httpClient.PostAsJsonAsync("https://projetosd-d46bb-default-rtdb.firebaseio.com/interop.json", mensagem);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(response);
Console.ForegroundColor = defaultColor;

record Mensagem(DateTime DataHora, string Conteudo, Guid Id);