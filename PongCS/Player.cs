using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongCS
{
    public class Player
    {
        public Player(int x, int y)
        {
            this._score = 0;
            this._pts = new Point[2];
            this._loc = new Point(x, y);
            this._speed = 8;
        }

        #region Members
        private int _score;     // score
        private Point _loc;     // location
        public const int LENGTH = 128;  // length of player
        private int _speed;     // speed
        private Point[] _pts;   // previous location and current location in an array used to calculate velocity
        private Velocity _vel;  // velocity
        #endregion

        #region Properties
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }

        public Point Location
        {
            get
            {
                return _loc;
            }
            set
            {
                _pts[0] = _loc; // set initial position
                _pts[1] = value;    // set current position

                _loc = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                if (value <= 8)
                {
                    _speed = 8;
                }
                else
                {
                    _speed = value;
                }
            }
        }

        public Velocity Velocity
        {
            get
            {
                return _vel;
            }

            set
            {
                _vel = new Velocity(_vel.X, _pts[0].Y - _pts[1].Y);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Used to smoothly reset player speed
        /// </summary>
        public void slowPlayer()
        {
            if (GlobVars.includeAccel)
            {
                while (this._speed > 8)
                {
                    this._speed -= 4;
                    this._loc.Y += (int)(-1 * (this._vel.Y / Math.Abs(this._vel.Y))) * this._speed;   // DOES NOT WORK AS INTENDED
                }
            }
            else
            {
                this._speed = 8;
            }

        }
        #endregion
    }
}