using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal class Podcast : IContenutoRiproducibile
    {
        private string name;
        private string host;
        private string guests;
        private int duration;

        public Podcast(string name, string host, string guests, int duration)
        {
            this.name = name;
            this.host = host;
            this.guests = guests;
            this.duration = duration;
        }
        public string Name { get { return name; } }
        public string Host { get { return host; } }
        public string Guests { get { return guests; } }
        public int Duration { get { return duration; } }

        public void SetName(string name) { this.name = name;}
        public void SetHost(string host) { this.host = host;}
        public void SetGuests(string guests) { this.guests = guests;}
        public void SetDuration(int duration) { this.duration = duration;}

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
