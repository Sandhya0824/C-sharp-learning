using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplication
{
    internal class LinuxAudioPlayerFactory : AudioPlayerFactory
    {
        public override IAudioPlayer CreateAudioPlayer()
        {
            return new LinuxAudioPlayer();
        }
    }
}
