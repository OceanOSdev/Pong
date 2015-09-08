using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace PongCS
{
    public partial class frmMain : Form
    {
        #region Members
        Ball ball = new Ball(43, 174);
        Player player = new Player(28, 145);
        Player computer = new Player(771, 145);
        bool multiPlayer = false;       // default postion
        Thread musicThread;
        #endregion

        /// <summary>
        /// Gets Key state in separate thread.
        /// </summary>
        /// <param name="vKey"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys key);

        public frmMain()
        {
            InitializeComponent();

            // Instantiates the Music class, which will be used in a separate thread.
            Music mus = new Music();

            // Create the thread object, passing in Music.Play method
            // via a ThreadStart delegate. This does not start the thread.
            musicThread = new Thread(new ThreadStart(mus.Play));

            musicThread.Priority = ThreadPriority.AboveNormal;

            // Start the thread
            musicThread.Start();

            // Spin for a while waiting for the started thread to become alive
            while (!musicThread.IsAlive) ;

            
        }

        private void setLocation(Player pl, Point pt)
        {
            pl.Location = pt;
        }

        /// <summary>
        /// The tick event is going to be the game loop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrClock_Tick(object sender, EventArgs e)
        {

            // Bind the picture box locations to the class location property
            this.paddleComputer.Location = computer.Location;
            this.paddlePlayer.Location = player.Location;
            this.picBall.Location = ball.Location;

            #region Player Movement
            // Moves player up
            if ((GetAsyncKeyState(Keys.W) < 0) & (player.Location.Y > 0))
            {
                setLocation(player, new Point(player.Location.X, player.Location.Y - player.Speed));
                if (GlobVars.includeAccel) player.Speed++;  // accelerate the paddle
            }

            // Moves player down
            else if ((GetAsyncKeyState(Keys.S) < 0) & (player.Location.Y < 300))
            {
                setLocation(player, new Point(player.Location.X, player.Location.Y + player.Speed));
                if (GlobVars.includeAccel) player.Speed++;  // accelerate the paddle
            }
            else
            {
                player.slowPlayer();
                //player.Speed = 8;   // reset paddle speed
            }
            #endregion

            #region Computer Player Movement
            if (!multiPlayer)
            {
                // Match the computer with the ball's Y coord
                if ((ball.Location.Y > 5) & (ball.Location.Y < this.Height - 40 - paddlePlayer.Height))
                {
                    setLocation(computer, new Point(computer.Location.X, ball.Location.Y));
                }
            }
            else
            {
                // Move player up
                if (((GetAsyncKeyState(Keys.Up) < 0) | (GetAsyncKeyState(Keys.I) < 0)) & (computer.Location.Y > 0))
                {
                    setLocation(computer, new Point(computer.Location.X, computer.Location.Y - computer.Speed));
                    computer.Speed++;   // accelerate paddle
                }
                
                // move player down
                else if (((GetAsyncKeyState(Keys.Down) < 0) | (GetAsyncKeyState(Keys.K) < 0)) & (computer.Location.Y < 300))
                {
                    setLocation(computer, new Point(computer.Location.X, computer.Location.Y + computer.Speed));
                    computer.Speed++;   // accelerate paddle
                }

                else
                {
                    computer.Speed = 8;     // reset paddle speed
                }
            }
            #endregion

            #region Multiplayer
            if (GetAsyncKeyState(Keys.P) < 0)
            {
                multiPlayer = !multiPlayer; // toggle multiplayer by setting itself to its negated value
            }
            #endregion

            #region Acceleration Toggle
            if (GetAsyncKeyState(Keys.O) < 0)
            {
                GlobVars.includeAccel = !GlobVars.includeAccel; // toggle acceleration by negating itself
            }
            #endregion

            #region Ball Movement
            // move the ball's location
            ball.Location = new Point((ball.Location.X + (int)ball.Velocity.X), (ball.Location.Y + (int)ball.Velocity.Y));
            #endregion

            #region Collision
            // Check for top wall collision
            if (ball.Location.Y < 0)
            {
                ball.Location = new Point(ball.Location.X, 0);
                ball.Velocity = new Velocity(ball.Velocity.X, -ball.Velocity.Y);
            }

            // Check for bottom wall collision
            if (ball.Location.Y > (this.Height - picBall.Size.Height - 45))
            {
                ball.Location = new Point(ball.Location.X, this.Height - picBall.Size.Height - 45);
                ball.Velocity = new Velocity(ball.Velocity.X, -ball.Velocity.Y);
            }

            // Check for computer paddle collision. I need to make the condition dependent on the class properties not the pictureboxes, but that can wait for now
            if (picBall.Bounds.IntersectsWith(paddleComputer.Bounds))
            {
                // alert GlobVars
                GlobVars.collided = true;

                collide(computer);
                //ball.Location = new Point(computer.Location.X - paddleComputer.Size.Width - 2, ball.Location.Y);
                //ball.Velocity = new Velocity(-ball.Velocity.X, ball.Velocity.Y);
            }

            // Check for player paddle collision. I need to make the condition dependent on the class properties not the pictureboxes, but that can wait for now
            if (picBall.Bounds.IntersectsWith(paddlePlayer.Bounds))
            {
                // alert GlobVars
                GlobVars.collided = true;

                collide(player);
                //ball.Location = new Point(player.Location.X + paddlePlayer.Size.Width + 2, ball.Location.Y);
                //ball.Velocity = new Velocity(-ball.Velocity.X, ball.Velocity.Y);
            }

            // Check for right wall collision
            if (ball.Location.X > this.Width - picBall.Size.Width - paddlePlayer.Width)
            {
                player.Score++;
                ball.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
                lblPlayerScore.Text = player.Score.ToString();
            }

            // Check for left wall collision
            if (ball.Location.X < 0)
            {
                computer.Score++;
                ball.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
                lblComputerScore.Text = computer.Score.ToString();
            }
            #endregion

            #region ReBind
            // Bind the picture box locations to the class location property again 
            this.paddleComputer.Location = computer.Location;
            this.paddlePlayer.Location = player.Location;
            this.picBall.Location = ball.Location;
            #endregion

            this.Refresh();     // prevents screen tearing, kinda
            player.Velocity = new Velocity(1, 1);   // "Efficient workaround"(i.e. dirty hack) to enable event handling, w/o actually using events
            /// <DEBUG CODE>
            //this.Text = string.Concat("Acceleration? ", GlobVars.includeAccel.ToString());
            ///</DEBUG CODE>
        }

        private void pseudoFriction(Player pl)
        {
            //TODO
        }

        private void collide(Player pl)
        {
            double dYPosition = (ball.Location.Y + (ball.HEIGHT/(2.0))) - pl.Location.Y;    // position of middle of ball relative to paddle 
            int newYVelocity = 0;   // initial

            // This is not elegant whatsoever and for that i sincerely apologize,
            // however there was no other way i could think of at the time 
            #region Negative Velocity
            if (Enumerable.Range(1,8).Contains((int)dYPosition))
            {
                newYVelocity = -8;
            }
            if (Enumerable.Range(9, 16).Contains((int)dYPosition))
            {
                newYVelocity = -7;
            }
            if (Enumerable.Range(17, 24).Contains((int)dYPosition))
            {
                newYVelocity = -6;
            }
            if (Enumerable.Range(25, 32).Contains((int)dYPosition))
            {
                newYVelocity = -5;
            }
            if (Enumerable.Range(33, 40).Contains((int)dYPosition))
            {
                newYVelocity = -4;
            }
            if (Enumerable.Range(41, 48).Contains((int)dYPosition))
            {
                newYVelocity = -3;
            }
            if (Enumerable.Range(49, 56).Contains((int)dYPosition))
            {
                newYVelocity = -2;
            }
            if (Enumerable.Range(57, 64).Contains((int)dYPosition))
            {
                newYVelocity = -1;
            }
            #endregion

            #region Positive Velocity
            if (Enumerable.Range(65, 72).Contains((int)dYPosition))
            {
                newYVelocity = 1;
            }
            if (Enumerable.Range(73, 80).Contains((int)dYPosition))
            {
                newYVelocity = 2;
            }
            if (Enumerable.Range(81, 88).Contains((int)dYPosition))
            {
                newYVelocity = 3;
            }
            if (Enumerable.Range(89, 96).Contains((int)dYPosition))
            {
                newYVelocity = 4;
            }
            if (Enumerable.Range(97, 104).Contains((int)dYPosition))
            {
                newYVelocity = 5;
            }
            if (Enumerable.Range(105, 112).Contains((int)dYPosition))
            {
                newYVelocity = 6;
            }
            if (Enumerable.Range(113, 120).Contains((int)dYPosition))
            {
                newYVelocity = 7;
            }
            if (Enumerable.Range(121, 128).Contains((int)dYPosition))
            {
                newYVelocity = 8;
            }
            #endregion
            Point loc = new Point();
            if (pl == player)
            {
                loc = new Point(pl.Location.X + pl.WIDTH + 2, ball.Location.Y);
            }
            else
            {
                loc = new Point(pl.Location.X - pl.WIDTH - 2, ball.Location.Y);
            }
            ball.Location = loc;
            ball.Velocity = new Velocity(-ball.Velocity.X, newYVelocity);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicThread.Interrupt();
            musicThread.Abort();
        }
    }
}
