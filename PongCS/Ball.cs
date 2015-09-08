using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongCS
{
    public class Ball
    {

        public Ball(int x, int y)
        {
            //Default initialized properties
            _speed = 10;
            _loc = new Point(x, y);
            Random rndInst = new Random();
            float x_vel = (float)(((rndInst.Next(1, 2) % 2) * (-1)) * (rndInst.Next(7, 9) / 10.0)) * _speed;  // sets a random x velocity between (-)7 and (-)9
            float y_vel = (float)(((rndInst.Next(1, 2) % 2) * (-1)) * (rndInst.Next(3, 5) / 10.0)) * _speed;  // sets a random y velocity between (-)3 and (-)5
            _vel = new Velocity(x_vel, 7);
        }

        #region Members
        private float _speed;
        private Velocity _vel;
        private Point _loc;
        public const int _HEIGHT = 20;
        #endregion

        #region Properties
        
        // speed property
        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        // Velocity property
        public Velocity Velocity
        {
            get
            {
                return _vel;
            }
            set
            {
                _vel = value;
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

        public int HEIGHT
        {
            get
            {
                return _HEIGHT;
            }
        }
        #endregion
    }

    /// <summary>
    /// Keeps track of the velocity of object
    /// </summary>
    public struct Velocity
    {
        public readonly float X;
        public readonly float Y;

        public Velocity(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

    }
}
