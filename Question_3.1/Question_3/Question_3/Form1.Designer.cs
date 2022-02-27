namespace Question_3
{
    partial class Form1
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
            this.btn_Rock = new System.Windows.Forms.Button();
            this.btn_Paper = new System.Windows.Forms.Button();
            this.btn_Scissors = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.picture_Player = new System.Windows.Forms.PictureBox();
            this.picture_CPU = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.Label();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.txtRound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Rock
            // 
            this.btn_Rock.Location = new System.Drawing.Point(37, 88);
            this.btn_Rock.Name = "btn_Rock";
            this.btn_Rock.Size = new System.Drawing.Size(75, 33);
            this.btn_Rock.TabIndex = 0;
            this.btn_Rock.Text = "Rock";
            this.btn_Rock.UseVisualStyleBackColor = true;
            this.btn_Rock.Click += new System.EventHandler(this.btn_Rock_Click);
            // 
            // btn_Paper
            // 
            this.btn_Paper.Location = new System.Drawing.Point(37, 186);
            this.btn_Paper.Name = "btn_Paper";
            this.btn_Paper.Size = new System.Drawing.Size(75, 34);
            this.btn_Paper.TabIndex = 1;
            this.btn_Paper.Text = "Paper";
            this.btn_Paper.UseVisualStyleBackColor = true;
            this.btn_Paper.Click += new System.EventHandler(this.btn_Paper_Click);
            // 
            // btn_Scissors
            // 
            this.btn_Scissors.Location = new System.Drawing.Point(37, 275);
            this.btn_Scissors.Name = "btn_Scissors";
            this.btn_Scissors.Size = new System.Drawing.Size(75, 34);
            this.btn_Scissors.TabIndex = 2;
            this.btn_Scissors.Text = "Scissors";
            this.btn_Scissors.UseVisualStyleBackColor = true;
            this.btn_Scissors.Click += new System.EventHandler(this.btn_Scissors_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(37, 370);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 33);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // picture_Player
            // 
            this.picture_Player.Image = global::Question_3.Properties.Resources.Question;
            this.picture_Player.Location = new System.Drawing.Point(164, 88);
            this.picture_Player.Name = "picture_Player";
            this.picture_Player.Size = new System.Drawing.Size(208, 221);
            this.picture_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Player.TabIndex = 4;
            this.picture_Player.TabStop = false;
            // 
            // picture_CPU
            // 
            this.picture_CPU.Image = global::Question_3.Properties.Resources.Question;
            this.picture_CPU.Location = new System.Drawing.Point(513, 88);
            this.picture_CPU.Name = "picture_CPU";
            this.picture_CPU.Size = new System.Drawing.Size(208, 221);
            this.picture_CPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_CPU.TabIndex = 5;
            this.picture_CPU.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(402, 42);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(79, 34);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "0 - 0";
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(423, 286);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(33, 34);
            this.txtCount.TabIndex = 9;
            this.txtCount.Text = "5";
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRound.Location = new System.Drawing.Point(372, 370);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(132, 34);
            this.txtRound.TabIndex = 10;
            this.txtRound.Text = "Round 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_CPU);
            this.Controls.Add(this.picture_Player);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Scissors);
            this.Controls.Add(this.btn_Paper);
            this.Controls.Add(this.btn_Rock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rock;
        private System.Windows.Forms.Button btn_Paper;
        private System.Windows.Forms.Button btn_Scissors;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.PictureBox picture_Player;
        private System.Windows.Forms.PictureBox picture_CPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Label txtRound;
    }
}

