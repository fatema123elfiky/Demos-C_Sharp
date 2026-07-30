using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Multi_Implementation
{
    internal class SmartPhone : IMediaPlayer, IPhone, ICamera
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

        public void recordVideo()
        {
            throw new NotImplementedException();
        }

        public void sendSms()
        {
            throw new NotImplementedException();
        }

        public void takePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
