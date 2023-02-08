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

var response = httpClient.PostAsJsonAsync("https://projetosd-d46bb-default-rtdb.firebaseio.com/interop.json", mensagem);

Console.WriteLine(response.Result);

record Mensagem(DateTime DataHora, string Conteudo, Guid Id);