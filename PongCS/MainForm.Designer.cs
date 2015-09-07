namespace PongCS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.paddlePlayer = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.paddleComputer = new System.Windows.Forms.PictureBox();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.PictureBox8 = new System.Windows.Forms.PictureBox();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.PictureBox10 = new System.Windows.Forms.PictureBox();
            this.PictureBox11 = new System.Windows.Forms.PictureBox();
            this.PictureBox12 = new System.Windows.Forms.PictureBox();
            this.PictureBox13 = new System.Windows.Forms.PictureBox();
            this.PictureBox14 = new System.Windows.Forms.PictureBox();
            this.PictureBox15 = new System.Windows.Forms.PictureBox();
            this.PictureBox16 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddlePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // paddlePlayer
            // 
            this.paddlePlayer.BackColor = System.Drawing.Color.White;
            this.paddlePlayer.Location = new System.Drawing.Point(42, 223);
            this.paddlePlayer.Name = "paddlePlayer";
            this.paddlePlayer.Size = new System.Drawing.Size(16, 128);
            this.paddlePlayer.TabIndex = 0;
            this.paddlePlayer.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Location = new System.Drawing.Point(64, 268);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // paddleComputer
            // 
            this.paddleComputer.BackColor = System.Drawing.Color.White;
            this.paddleComputer.Location = new System.Drawing.Point(1156, 223);
            this.paddleComputer.Name = "paddleComputer";
            this.paddleComputer.Size = new System.Drawing.Size(16, 128);
            this.paddleComputer.TabIndex = 2;
            this.paddleComputer.TabStop = false;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.White;
            this.lblComputerScore.Location = new System.Drawing.Point(622, 18);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(118, 37);
            this.lblComputerScore.TabIndex = 3;
            this.lblComputerScore.Text = "0";
            this.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(472, 18);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(118, 37);
            this.lblPlayerScore.TabIndex = 4;
            this.lblPlayerScore.Text = "0";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Location = new System.Drawing.Point(597, 268);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.White;
            this.PictureBox2.Location = new System.Drawing.Point(597, 234);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(20, 20);
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.White;
            this.PictureBox3.Location = new System.Drawing.Point(597, 168);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(20, 20);
            this.PictureBox3.TabIndex = 8;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.White;
            this.PictureBox4.Location = new System.Drawing.Point(597, 202);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(20, 20);
            this.PictureBox4.TabIndex = 7;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.BackColor = System.Drawing.Color.White;
            this.PictureBox5.Location = new System.Drawing.Point(597, 35);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(20, 20);
            this.PictureBox5.TabIndex = 12;
            this.PictureBox5.TabStop = false;
            // 
            // PictureBox6
            // 
            this.PictureBox6.BackColor = System.Drawing.Color.White;
            this.PictureBox6.Location = new System.Drawing.Point(597, 69);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(20, 20);
            this.PictureBox6.TabIndex = 11;
            this.PictureBox6.TabStop = false;
            // 
            // PictureBox7
            // 
            this.PictureBox7.BackColor = System.Drawing.Color.White;
            this.PictureBox7.Location = new System.Drawing.Point(597, 102);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(20, 20);
            this.PictureBox7.TabIndex = 10;
            this.PictureBox7.TabStop = false;
            // 
            // PictureBox8
            // 
            this.PictureBox8.BackColor = System.Drawing.Color.White;
            this.PictureBox8.Location = new System.Drawing.Point(597, 135);
            this.PictureBox8.Name = "PictureBox8";
            this.PictureBox8.Size = new System.Drawing.Size(20, 20);
            this.PictureBox8.TabIndex = 9;
            this.PictureBox8.TabStop = false;
            // 
            // PictureBox9
            // 
            this.PictureBox9.BackColor = System.Drawing.Color.White;
            this.PictureBox9.Location = new System.Drawing.Point(597, 300);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(20, 20);
            this.PictureBox9.TabIndex = 20;
            this.PictureBox9.TabStop = false;
            // 
            // PictureBox10
            // 
            this.PictureBox10.BackColor = System.Drawing.Color.White;
            this.PictureBox10.Location = new System.Drawing.Point(597, 332);
            this.PictureBox10.Name = "PictureBox10";
            this.PictureBox10.Size = new System.Drawing.Size(20, 20);
            this.PictureBox10.TabIndex = 19;
            this.PictureBox10.TabStop = false;
            // 
            // PictureBox11
            // 
            this.PictureBox11.BackColor = System.Drawing.Color.White;
            this.PictureBox11.Location = new System.Drawing.Point(597, 366);
            this.PictureBox11.Name = "PictureBox11";
            this.PictureBox11.Size = new System.Drawing.Size(20, 20);
            this.PictureBox11.TabIndex = 18;
            this.PictureBox11.TabStop = false;
            // 
            // PictureBox12
            // 
            this.PictureBox12.BackColor = System.Drawing.Color.White;
            this.PictureBox12.Location = new System.Drawing.Point(597, 398);
            this.PictureBox12.Name = "PictureBox12";
            this.PictureBox12.Size = new System.Drawing.Size(20, 20);
            this.PictureBox12.TabIndex = 17;
            this.PictureBox12.TabStop = false;
            // 
            // PictureBox13
            // 
            this.PictureBox13.BackColor = System.Drawing.Color.White;
            this.PictureBox13.Location = new System.Drawing.Point(597, 432);
            this.PictureBox13.Name = "PictureBox13";
            this.PictureBox13.Size = new System.Drawing.Size(20, 20);
            this.PictureBox13.TabIndex = 16;
            this.PictureBox13.TabStop = false;
            // 
            // PictureBox14
            // 
            this.PictureBox14.BackColor = System.Drawing.Color.White;
            this.PictureBox14.Location = new System.Drawing.Point(597, 465);
            this.PictureBox14.Name = "PictureBox14";
            this.PictureBox14.Size = new System.Drawing.Size(20, 20);
            this.PictureBox14.TabIndex = 15;
            this.PictureBox14.TabStop = false;
            // 
            // PictureBox15
            // 
            this.PictureBox15.BackColor = System.Drawing.Color.White;
            this.PictureBox15.Location = new System.Drawing.Point(597, 498);
            this.PictureBox15.Name = "PictureBox15";
            this.PictureBox15.Size = new System.Drawing.Size(20, 20);
            this.PictureBox15.TabIndex = 14;
            this.PictureBox15.TabStop = false;
            // 
            // PictureBox16
            // 
            this.PictureBox16.BackColor = System.Drawing.Color.White;
            this.PictureBox16.Location = new System.Drawing.Point(597, 531);
            this.PictureBox16.Name = "PictureBox16";
            this.PictureBox16.Size = new System.Drawing.Size(20, 20);
            this.PictureBox16.TabIndex = 13;
            this.PictureBox16.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1215, 585);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.PictureBox9);
            this.Controls.Add(this.PictureBox10);
            this.Controls.Add(this.PictureBox11);
            this.Controls.Add(this.PictureBox12);
            this.Controls.Add(this.PictureBox13);
            this.Controls.Add(this.PictureBox14);
            this.Controls.Add(this.PictureBox15);
            this.Controls.Add(this.PictureBox16);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.PictureBox6);
            this.Controls.Add(this.PictureBox7);
            this.Controls.Add(this.PictureBox8);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.paddleComputer);
            this.Controls.Add(this.paddlePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Pong CS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.paddlePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox16)).EndInit();
            this.ResumeLayout(false);

        }
        
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.PictureBox paddlePlayer;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox paddleComputer;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox PictureBox4;
        private System.Windows.Forms.PictureBox PictureBox5;
        private System.Windows.Forms.PictureBox PictureBox6;
        private System.Windows.Forms.PictureBox PictureBox7;
        private System.Windows.Forms.PictureBox PictureBox8;
        private System.Windows.Forms.PictureBox PictureBox9;
        private System.Windows.Forms.PictureBox PictureBox10;
        private System.Windows.Forms.PictureBox PictureBox11;
        private System.Windows.Forms.PictureBox PictureBox12;
        private System.Windows.Forms.PictureBox PictureBox13;
        private System.Windows.Forms.PictureBox PictureBox14;
        private System.Windows.Forms.PictureBox PictureBox15;
        private System.Windows.Forms.PictureBox PictureBox16;
        
        #endregion
    }
}

