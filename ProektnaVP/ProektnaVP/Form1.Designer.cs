namespace ProektnaVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.NewRockTimer = new System.Windows.Forms.Timer(this.components);
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.pbStartBackgrounf = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbYourScore = new System.Windows.Forms.Label();
            this.CoinsTimer = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.CloudTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStartBackgrounf)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveTimer
            // 
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // NewRockTimer
            // 
            this.NewRockTimer.Interval = 1800;
            this.NewRockTimer.Tick += new System.EventHandler(this.NewRockTimer_Tick);
            // 
            // DrawTimer
            // 
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // pbStartBackgrounf
            // 
            this.pbStartBackgrounf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStartBackgrounf.BackgroundImage")));
            this.pbStartBackgrounf.Location = new System.Drawing.Point(-6, -2);
            this.pbStartBackgrounf.Name = "pbStartBackgrounf";
            this.pbStartBackgrounf.Size = new System.Drawing.Size(479, 344);
            this.pbStartBackgrounf.TabIndex = 12;
            this.pbStartBackgrounf.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 60);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHigh
            // 
            this.btnHigh.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHigh.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigh.Location = new System.Drawing.Point(12, 150);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(153, 60);
            this.btnHigh.TabIndex = 16;
            this.btnHigh.Text = "HIGH SCORE";
            this.btnHigh.UseVisualStyleBackColor = false;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Turquoise;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 70);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 60);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(303, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // lbYourScore
            // 
            this.lbYourScore.AutoSize = true;
            this.lbYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourScore.ForeColor = System.Drawing.Color.Coral;
            this.lbYourScore.Location = new System.Drawing.Point(-2, 9);
            this.lbYourScore.Name = "lbYourScore";
            this.lbYourScore.Size = new System.Drawing.Size(85, 29);
            this.lbYourScore.TabIndex = 19;
            this.lbYourScore.Text = "label2";
            // 
            // CoinsTimer
            // 
            this.CoinsTimer.Interval = 1200;
            this.CoinsTimer.Tick += new System.EventHandler(this.CoinsTimer_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.OrangeRed;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(206, 86);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(115, 39);
            this.lbScore.TabIndex = 20;
            this.lbScore.Text = "label3";
            // 
            // CloudTimer
            // 
            this.CloudTimer.Interval = 4500;
            this.CloudTimer.Tick += new System.EventHandler(this.CloudTimer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 312);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbYourScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbStartBackgrounf);
            this.Name = "Form1";
            this.Text = "SHOOTING PLANE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbStartBackgrounf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer NewRockTimer;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.PictureBox pbStartBackgrounf;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbYourScore;
        private System.Windows.Forms.Timer CoinsTimer;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer CloudTimer;
    }
}

