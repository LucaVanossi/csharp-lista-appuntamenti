// See https://aka.ms/new-console-template for more information

using ListaAppuntamenti;

Console.WriteLine("Quanti appuntamenti vuoi inserire?");

int NrAppuntamenti = int.Parse(Console.ReadLine());

List<Appuntamento> Appuntamenti = new List<Appuntamento>(NrAppuntamenti);

DateTime DataAppuntamento = DateTime.Now;
string NomeAppuntamento = "";
string Localita = "";


for (int i = 0; i < NrAppuntamenti; i++)
{
    bool dataOggi = false;
    while (!dataOggi)
    {
        
        bool isData = false;
        while (!isData)
        {
            Console.WriteLine("Data e ora del tuo appuntamento: gg/mm/aaaa hh:mm");
            try
            {
                DataAppuntamento = DateTime.Parse(Console.ReadLine()); 
                isData = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Data errata !");
            }
            if (DataAppuntamento <= DateTime.Now)
            {
                Console.WriteLine("Data minore di oggi");
            }
            else dataOggi = true;
        }
    }
    
    Console.WriteLine("Nome: ");
    NomeAppuntamento = Console.ReadLine();
    Console.WriteLine("Luogo Appuntamento: ");
    Localita = Console.ReadLine();
    Appuntamenti.Add(new Appuntamento(DataAppuntamento, NomeAppuntamento, Localita));
    
}
Console.WriteLine("-------------------------------");
foreach (Appuntamento p in Appuntamenti)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine("-------------------------------");
}
Console.ReadKey();
Console.WriteLine("Nome: ");
String NomeAppu = Console.ReadLine();
List<Appuntamento> Appuntamenticerca = new List<Appuntamento>(NrAppuntamenti);
Appuntamenticerca.FindAll(p => p.Nome == NomeAppu);
Console.WriteLine("Inserisci la nuova data: ");
DataAppuntamento = DateTime.Parse(Console.ReadLine());
//Appuntamento.CambiaData(DataAppuntamento);

Console.WriteLine("-------------------------------");
foreach (Appuntamento p in Appuntamenti)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine("-------------------------------");
}



