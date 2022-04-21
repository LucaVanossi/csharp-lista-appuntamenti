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
    Console.WriteLine("Data e ora: ");
    DataAppuntamento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Nome: ");
    NomeAppuntamento = Console.ReadLine();
    Console.WriteLine("Luogo Appuntamento: ");
    Localita = Console.ReadLine();
    Appuntamenti.Add(new Appuntamento ( DataAppuntamento, NomeAppuntamento, Localita ));

}

foreach (Appuntamento p in Appuntamenti)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine("-------------------------------");
}




