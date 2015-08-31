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
            _loc = new Point(x, y);
        }

        #region Members
        private int _score;
        private Point _loc;
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
                _loc = value;
            }
        }
        #endregion
    }
}