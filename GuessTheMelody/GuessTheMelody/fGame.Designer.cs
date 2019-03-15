namespace GuessTheMelody
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.bNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGamer2 = new System.Windows.Forms.Label();
            this.labelGamer1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bPause = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.lblMelodyCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMusicDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 12);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(21, 284);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(133, 89);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "Следующая";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            // 
            // labelGamer2
            // 
            this.labelGamer2.AutoSize = true;
            this.labelGamer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamer2.Location = new System.Drawing.Point(394, 93);
            this.labelGamer2.Name = "labelGamer2";
            this.labelGamer2.Size = new System.Drawing.Size(31, 33);
            this.labelGamer2.TabIndex = 3;
            this.labelGamer2.Text = "0";
            // 
            // labelGamer1
            // 
            this.labelGamer1.AutoSize = true;
            this.labelGamer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamer1.Location = new System.Drawing.Point(91, 93);
            this.labelGamer1.Name = "labelGamer1";
            this.labelGamer1.Size = new System.Drawing.Size(31, 33);
            this.labelGamer1.TabIndex = 4;
            this.labelGamer1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(346, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Игрог 2";
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(185, 284);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(133, 89);
            this.bPause.TabIndex = 6;
            this.bPause.Text = "Пауза";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bContinue
            // 
            this.bContinue.Location = new System.Drawing.Point(344, 284);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(133, 89);
            this.bContinue.TabIndex = 7;
            this.bContinue.Text = "Продолжить";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // lblMelodyCount
            // 
            this.lblMelodyCount.AutoSize = true;
            this.lblMelodyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMelodyCount.Location = new System.Drawing.Point(237, 93);
            this.lblMelodyCount.Name = "lblMelodyCount";
            this.lblMelodyCount.Size = new System.Drawing.Size(31, 33);
            this.lblMelodyCount.TabIndex = 8;
            this.lblMelodyCount.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(456, 43);
            this.progressBar1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMusicDuration
            // 
            this.labelMusicDuration.AutoSize = true;
            this.labelMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMusicDuration.Location = new System.Drawing.Point(237, 51);
            this.labelMusicDuration.Name = "labelMusicDuration";
            this.labelMusicDuration.Size = new System.Drawing.Size(31, 33);
            this.labelMusicDuration.TabIndex = 10;
            this.labelMusicDuration.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 385);
            this.Controls.Add(this.labelMusicDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblMelodyCount);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGamer1);
            this.Controls.Add(this.labelGamer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGamer2;
        private System.Windows.Forms.Label labelGamer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Label lblMelodyCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMusicDuration;
    }
}