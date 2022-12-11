using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal class Podcast : ContenutoAudio
    {
    
        private string host;
        private string guests;
       

        public Podcast(string name, string host, string guests, int duration):base(name,duration) 
        {
           
            this.host = host;
            this.guests = guests;
            
        }
       
        public string Host { get { return host; } }
        public string Guests { get { return guests; } }

        public void SetHost(string host) { this.host = host;}
        public void SetGuests(string guests) { this.guests = guests;}

        public override void Pause()
        {

            Console.WriteLine("Messo in pausa il podcast "+GetName+" di "+host+" & "+guests+".");
        }

        public override void Play()
        {
            Console.WriteLine("Riproduzione del podcast " + GetName + " di " + host + " & " + guests +".");
        }

        public override void Stop()
        {
            Console.WriteLine("Messo in stop il podcast " + GetName + " di " + host + " & " + guests +" e riavvolto all’inizio del podcast.");
        }
    }
}
