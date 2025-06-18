List<string> davetliler = new List<string>();
for (int i = 0; i < 5; i++)
{
    Console.Write("Eklemek istediğiniz davetli:");
    string davetli = Console.ReadLine();
    davetliler.Add(davetli);
}
Console.WriteLine("-------- BALONUN DAVETLİLERİ --------");
foreach (var davetli in davetliler)
{
    string yazdir = char.ToUpper(davetli[0]) + davetli[1..].ToLower();  
    Console.WriteLine(yazdir);
}