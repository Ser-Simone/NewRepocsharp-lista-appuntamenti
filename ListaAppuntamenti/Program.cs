
using ListaAppuntamenti;


Console.WriteLine("Quanti appuntamenti vuoi inserire?");
int numAppuntamenti = int.Parse(Console.ReadLine());



List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

for (int i = 0; i < numAppuntamenti; i++)
{
    Console.WriteLine("inserisci il tuo nome");
    string nome = Console.ReadLine();
    Console.WriteLine("inserisci il tuo cognome");
    string cognome = Console.ReadLine();

    Console.WriteLine("inserisci il titolo dell'appuntamento");
   string titoloAppuntamento =  Console.ReadLine();

    Console.WriteLine("inserisci il luogo dell'appuntamento");
    string luogoAppuntamento = Console.ReadLine();

    Console.WriteLine("inserisci la data dell'appuntamento");
    string dataAppuntamento = Console.ReadLine();
    Appuntamento.checkdata(dataAppuntamento);
    DateTime dataInserita = DateTime.Parse(dataAppuntamento);

    Appuntamento appuntamento1 = new Appuntamento(nome, cognome, titoloAppuntamento,luogoAppuntamento, dataInserita);
    listaAppuntamenti.Add(appuntamento1);
}

foreach (Appuntamento appuntamento in listaAppuntamenti)
{
    appuntamento.ToString();
}

Console.WriteLine("Vuoi Cambiare un appuntamento?");
string risposta = Console.ReadLine();


if (risposta == "si")

{
    Appuntamento.setcambiaAppuntamento()
}