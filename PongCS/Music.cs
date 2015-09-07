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
        const int MAX_VOLUME = 65535;
        #endregion

        #region Constructor
        public Music()
        {
            midiOut.Volume = 0;         // mutes output
            midiOut.Send(MidiMessage.ChangePatch(80, 1).RawData);   // changes the patch to a square wave
            midiOut.Send(startNote);    // The only way to get around the latency is to have it constantly play the note w/ a fluctuating volume
        }
        #endregion

        #region Destructor
        ~Music()
        {
            //midiOut.Send(stopNote);
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
                    midiOut.Volume = MAX_VOLUME;    // Turns up volume
                    Thread.Sleep(125);              // "Play note" (i.e. take it off of mute) for 125 milliseconds
                    midiOut.Volume = 0;             // mute it
                    Thread.Sleep(10);
                    GlobVars.collided = false;      // reset state
                }
            }
        }
        #endregion
    }
}
