using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplication
{
    internal interface IAudioPlayerFactory
    {
        IAudioPlayer CreateAudioPlayer();
    }
}
