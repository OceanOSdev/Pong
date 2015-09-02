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

namespace PongCS
{
    public partial class frmMain : Form
    {
        #region Members
        Ball ball = new Ball(43, 174);
        Player player = new Player(28, 145);
        Player computer = new Player(771, 145);
        bool multiPlayer = false;       // default postion
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
                setLocation(player, new Point(player.Location.X, player.Location.Y - 8));
            }

            // Moves player down
            if ((GetAsyncKeyState(Keys.S) < 0) & (player.Location.Y < 300))
            {
                setLocation(player, new Point(player.Location.X, player.Location.Y + 8));
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
                // Move player two up
                if (((GetAsyncKeyState(Keys.Up) < 0) | (GetAsyncKeyState(Keys.I) < 0)) & (computer.Location.Y > 0))
                {
                    setLocation(computer, new Point(computer.Location.X, computer.Location.Y - 8));
                }
                
                // move player two down
                if (((GetAsyncKeyState(Keys.Down) < 0) | (GetAsyncKeyState(Keys.K) < 0)) & (computer.Location.Y < 300))
                {
                    setLocation(computer, new Point(computer.Location.X, computer.Location.Y + 8));
                }
            }
            #endregion

            #region Multiplayer
            if (GetAsyncKeyState(Keys.P) < 0)
            {
                multiPlayer = !multiPlayer; // toggle multiplayer by setting itself to its negated value
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
                ball.Location = new Point(computer.Location.X - paddleComputer.Size.Width - 2, ball.Location.Y);
                ball.Velocity = new Velocity(-ball.Velocity.X, ball.Velocity.Y);                
            }

            // Check for player paddle collision. I need to make the condition dependent on the class properties not the pictureboxes, but that can wait for now
            if (picBall.Bounds.IntersectsWith(paddlePlayer.Bounds))
            {
                ball.Location = new Point(player.Location.X + paddlePlayer.Size.Width + 2, ball.Location.Y);
                ball.Velocity = new Velocity(-ball.Velocity.X, ball.Velocity.Y);
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
        }

    }
}
