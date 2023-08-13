using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplication
{
    public abstract class AudioPlayerFactory : IAudioPlayerFactory
    {
        public abstract IAudioPlayer CreateAudioPlayer();
    }
}
