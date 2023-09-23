namespace TicTacToeGame
{
    partial class FrmTicToeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicToeGame));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.lblWinnerValue = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(399, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(569, 76);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F);
            this.lblTurn.ForeColor = System.Drawing.Color.Gold;
            this.lblTurn.Location = new System.Drawing.Point(92, 138);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(126, 56);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "Turn";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F);
            this.lblWinner.ForeColor = System.Drawing.Color.Gold;
            this.lblWinner.Location = new System.Drawing.Point(63, 303);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(185, 56);
            this.lblWinner.TabIndex = 2;
            this.lblWinner.Text = "Winner";
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 25F);
            this.lblCurrentTurn.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblCurrentTurn.Location = new System.Drawing.Point(71, 206);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(169, 48);
            this.lblCurrentTurn.TabIndex = 3;
            this.lblCurrentTurn.Tag = "Player1";
            this.lblCurrentTurn.Text = "Player 1";
            // 
            // lblWinnerValue
            // 
            this.lblWinnerValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWinnerValue.AutoSize = true;
            this.lblWinnerValue.Font = new System.Drawing.Font("Berlin Sans FB Demi", 25F);
            this.lblWinnerValue.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblWinnerValue.Location = new System.Drawing.Point(48, 382);
            this.lblWinnerValue.Name = "lblWinnerValue";
            this.lblWinnerValue.Size = new System.Drawing.Size(215, 48);
            this.lblWinnerValue.TabIndex = 4;
            this.lblWinnerValue.Tag = "";
            this.lblWinnerValue.Text = "InProgress";
            this.lblWinnerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRestart.FlatAppearance.BorderSize = 2;
            this.btnRestart.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(44, 479);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(221, 59);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb1.Location = new System.Drawing.Point(31, 42);
            this.pb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(163, 102);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            this.pb1.Tag = " ";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb4.Location = new System.Drawing.Point(31, 166);
            this.pb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(163, 102);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 7;
            this.pb4.TabStop = false;
            this.pb4.Tag = " ";
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb2.Location = new System.Drawing.Point(223, 42);
            this.pb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(163, 102);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            this.pb2.Tag = " ";
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb3.Location = new System.Drawing.Point(415, 42);
            this.pb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(163, 102);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 9;
            this.pb3.TabStop = false;
            this.pb3.Tag = " ";
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb5.Location = new System.Drawing.Point(223, 166);
            this.pb5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(163, 102);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 10;
            this.pb5.TabStop = false;
            this.pb5.Tag = " ";
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb6.Location = new System.Drawing.Point(415, 166);
            this.pb6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(163, 102);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 11;
            this.pb6.TabStop = false;
            this.pb6.Tag = " ";
            this.pb6.Click += new System.EventHandler(this.pb6_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb8.Location = new System.Drawing.Point(223, 289);
            this.pb8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(163, 102);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 12;
            this.pb8.TabStop = false;
            this.pb8.Tag = " ";
            this.pb8.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb9
            // 
            this.pb9.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb9.Location = new System.Drawing.Point(415, 289);
            this.pb9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(163, 102);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 13;
            this.pb9.TabStop = false;
            this.pb9.Tag = " ";
            this.pb9.Click += new System.EventHandler(this.pb9_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.pb7.Location = new System.Drawing.Point(31, 289);
            this.pb7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(163, 102);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 14;
            this.pb7.TabStop = false;
            this.pb7.Tag = " ";
            this.pb7.Click += new System.EventHandler(this.pb7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pb7);
            this.panel1.Controls.Add(this.pb9);
            this.panel1.Controls.Add(this.pb8);
            this.panel1.Controls.Add(this.pb6);
            this.panel1.Controls.Add(this.pb5);
            this.panel1.Controls.Add(this.pb3);
            this.panel1.Controls.Add(this.pb2);
            this.panel1.Controls.Add(this.pb4);
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Location = new System.Drawing.Point(398, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 426);
            this.panel1.TabIndex = 15;
            // 
            // FrmTicToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1141, 635);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinnerValue);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTicToeGame";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTicToeGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Label lblWinnerValue;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.Panel panel1;
    }
}

