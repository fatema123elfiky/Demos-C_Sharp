using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Multi_Implementation
{
    internal interface IBehaviour
    {
        // send sms
        // call

        // play video
        // play music

        // record video
        // take photo

        public void Call();

        public void sendSms();

        public void playVideo();

        public void playMusic();

        public void recordVideo();

        public void takePhoto();

        // that is wrong as it is fat interface 
        // so split it why ? as simple phone could not do the last two features
        // so we should split it as not to be forced to implment something it could noot do it 
    }
}
