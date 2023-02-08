namespace Interop.Core;
//Classe para printar no console as mensagems
internal static class Print
{
    static ConsoleColor defaultColor;
    public static void Message(Mensagem mensagem)
    {
        defaultColor = Console.ForegroundColor;
        Console.WriteLine("Enviando Mensagem ao firebase!");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(mensagem);
    }
    public static async Task Response(HttpResponseMessage response)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(response);
        Console.WriteLine();

        var responseData = await response.Content.ReadAsStringAsync();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(responseData);
        Console.ForegroundColor = defaultColor;
    }
}
