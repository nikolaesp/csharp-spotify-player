using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal class ContenutoAudio : IContenutoRiproducibile
    {
        private string name;
        private int duration;
       

        public ContenutoAudio(string name , int duration)
        {
            this.name = name;
            this.duration = duration;
        }

     

        public string GetName() { return this.name; }
        public int GetDuration() { return this.duration; }
        public void SetName(string name) { this.name = name; }
        public void SetDuration(int duration) { this.duration = duration; }

        public virtual void Pause()
        {
            Console.WriteLine("Pause: " + this.GetName);
        }

        public virtual void Play()
        {
            Console.WriteLine("Play: " + this.GetName);
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stop: " + this.GetName);
        }
    }
}
