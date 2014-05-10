using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace ProektnaVP
{
    class Sound
    {
        
        private SoundPlayer GameOverMusic;
        
        private SoundPlayer MachineGun;

        public Sound()
        {

            GameOverMusic = new SoundPlayer(Properties.Resources.GameOver);

            MachineGun = new SoundPlayer(Properties.Resources.MashineGun);
        }
           
        
        public void playGameOverMusic()
        {
           GameOverMusic.Play();
        }
       

        public void playMachineGun()
        {
            MachineGun.Play();
        }
    }
}
