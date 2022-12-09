// See https://aka.ms/new-console-template for more information

using csharp_spotify_player;

Brano billie = new Brano("Billie Jean", "Michael Jackson", 5);
Podcast jre1070 = new Podcast("JRE#1070", "Joe Rogan", "Jordan Peterson", 130);
List<IContenutoRiproducibile> prova = new List<IContenutoRiproducibile>();
prova.Add(jre1070);
prova.Add(billie);

for(int i = 0; i < prova.Count; i++)
{
    prova[i].Play();
    prova[i].Pause();
    prova[i].Stop();
}
