using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal interface IContenutoRiproducibile
    {
        public void Play();
        public void Pause();
        public void Stop();
    }
}
