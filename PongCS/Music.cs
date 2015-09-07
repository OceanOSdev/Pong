using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Midi;
using System.Threading;

namespace PongCS
{
    /// <summary>
    /// Class for handling music and sounds
    /// </summary>
    public class Music
    {
        #region Constructor
        public Music()
        {
           
        }
        #endregion

        #region Music Player
        
        /// <summary>
        /// Plays midi note when collision is detected
        /// </summary>
        /// <remarks>
        /// To be ran in thread separate from UI
        /// </remarks>
        public void Play()
        {
            while (true)
            {
                if (GlobVars.collided)
                {
                    using (MidiOut midiOut = new MidiOut(0))
                    {
                        midiOut.Volume = 65535;
                        midiOut.Send(MidiMessage.StartNote(60, 127, 1).RawData);
                        //System.Windows.Forms.MessageBox.Show("Sent");
                        Thread.Sleep(500);
                        midiOut.Send(MidiMessage.StopNote(60, 0, 1).RawData);
                        Thread.Sleep(10);
                        GlobVars.collided = false;
                    }
                }
            }
        }
        #endregion
    }
}
