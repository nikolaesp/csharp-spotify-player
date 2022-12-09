using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal class Brano : IContenutoRiproducibile
    {
        private string  name;
        private string artist;
        private int duration;

        public Brano(string name, string artist, int duration)
        {
            this.name = name;
            this.artist = artist;
            this.duration = duration;

        }

        public string GetName() { return this.name; }
        public string GetArtist() { return this.artist;}
        public int GetDuration() { return this.duration;}
        public void SetName(string name) { this.name = name;}
        public void SetArtist(string artist) { this.artist = artist;}
        public void SetDuration(int duration) { this.duration = duration;}
        public void Pause()
        {
          
            Console.WriteLine("Messo in pausa il brano {$name} di {$artist}.");
        }

        public void Play()
        {
            Console.WriteLine("Riproduzione del brano {$name} di {$artist}.");
        }

        public void Stop()
        {
            Console.WriteLine("Messo in stop il brano {$name} di {$artist} e riavvolto all’inizio del brano");
        }
    }
}
