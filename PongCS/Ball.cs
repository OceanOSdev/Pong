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
            float x_vel = (float)(Math.Cos(rndInst.Next(5, 10)) * _speed);
            float y_vel = (float)(Math.Sin(rndInst.Next(5, 10)) * _speed);
            _vel = new Velocity(x_vel, y_vel);
        }

        #region Members
        private float _speed;
        private Velocity _vel;
        private Point _loc;
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
