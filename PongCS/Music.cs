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
        #region Members
        MidiOut midiOut = new MidiOut(0);
        int startNote = MidiMessage.StartNote(40, 127, 1).RawData;
        int stopNote = MidiMessage.StopNote(40, 0, 1).RawData;
        #endregion

        #region Constructor
        public Music()
        {
            midiOut.Volume = 65535;
            midiOut.Send(MidiMessage.ChangePatch(80, 1).RawData);
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
                    midiOut.Send(startNote);
                    //System.Windows.Forms.MessageBox.Show("Sent");
                    Thread.Sleep(250);
                    midiOut.Send(stopNote);
                    Thread.Sleep(10);
                    GlobVars.collided = false;
                }
            }
        }
        #endregion
    }
}
