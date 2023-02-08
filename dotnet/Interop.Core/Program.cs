using Interop.Core;
using System.Net.Http.Json;

HttpClient httpClient = new HttpClient();
Mensagem mensagem;

//Le o console por argumentos do executavel
if (args.Length > 0)
{
    var conteudo = args[0];
    mensagem = new Mensagem(DateTime.Now, conteudo, Guid.NewGuid());
}
else
{
    mensagem = new Mensagem(DateTime.Now, "Nenhuma Mensagem!", Guid.NewGuid());
}

//Escreve a mensagem no console
Print.Message(mensagem);

var response = await httpClient.PostAsJsonAsync("https://projetosd-d46bb-default-rtdb.firebaseio.com/interop.json", mensagem);

//Escreve a resposta no console
await Print.Response(response);