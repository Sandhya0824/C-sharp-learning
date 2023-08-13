using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplication
{
    public class WindowsAudioPlayer : IAudioPlayer
    {
        public void Play()
        {
            Console.WriteLine("In Windows, Audio is being played");
        }

        public void Stop()
        {
            Console.WriteLine("In Windows, Audio is being stopped!!!");
        }
    }
}
