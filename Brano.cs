using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal class Brano : ContenutoAudio
    {
      
        private string artist;



        public Brano(string artist, string name, int duration) : base(name, duration)
        {
            this.artist = artist;
        }
   
        public string GetArtist() { return this.artist;}
      
        public void SetArtist(string artist) { this.artist = artist;}
        

        public void print()
        {
            Console.WriteLine($"Brano: {GetName} di {artist} lungha: {GetDuration}min.");

        }
        public override void Pause()
        {

            Console.WriteLine("Messo in pausa il brano " + this.GetName() + " di " + GetArtist + ".");
        }

        public  override void Play()
        {
            Console.WriteLine("Riproduzione del brano "+GetName+" di "+GetArtist+".");
        }

        public override void Stop()
        {
            Console.WriteLine("Messo in stop il brano "+GetName+" di "+GetArtist+" e riavvolto all’inizio del brano");
        }
    }
}
