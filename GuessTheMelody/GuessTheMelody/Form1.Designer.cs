namespace GuessTheMelody
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.bPlay = new System.Windows.Forms.Button();
            this.bEsc = new System.Windows.Forms.Button();
            this.bParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPlay
            // 
            this.bPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlay.Location = new System.Drawing.Point(85, 41);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(323, 72);
            this.bPlay.TabIndex = 0;
            this.bPlay.Text = "Игра";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // bEsc
            // 
            this.bEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEsc.Location = new System.Drawing.Point(85, 201);
            this.bEsc.Name = "bEsc";
            this.bEsc.Size = new System.Drawing.Size(323, 72);
            this.bEsc.TabIndex = 1;
            this.bEsc.Text = "Выход";
            this.bEsc.UseVisualStyleBackColor = true;
            this.bEsc.Click += new System.EventHandler(this.button2_Click);
            // 
            // bParams
            // 
            this.bParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bParams.Location = new System.Drawing.Point(85, 121);
            this.bParams.Name = "bParams";
            this.bParams.Size = new System.Drawing.Size(323, 72);
            this.bParams.TabIndex = 2;
            this.bParams.Text = "Настройки";
            this.bParams.UseVisualStyleBackColor = true;
            this.bParams.Click += new System.EventHandler(this.button3_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 441);
            this.Controls.Add(this.bParams);
            this.Controls.Add(this.bEsc);
            this.Controls.Add(this.bPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Угадай мелодию";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bEsc;
        private System.Windows.Forms.Button bParams;
    }
}

