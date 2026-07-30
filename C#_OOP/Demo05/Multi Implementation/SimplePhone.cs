using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Multi_Implementation
{
    internal class SimplePhone : IMediaPlayer, IPhone
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void playMusic()
        {
            throw new NotImplementedException();
        }

        public void playVideo()
        {
            throw new NotImplementedException();
        }

        public void sendSms()
        {
            throw new NotImplementedException();
        }
    }
}
