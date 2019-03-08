namespace GuessTheMelody
{
    partial class fParam
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bSelectFolder = new System.Windows.Forms.Button();
            this.bClearList = new System.Windows.Forms.Button();
            this.checkBoxAllDirectory = new System.Windows.Forms.CheckBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGameDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxMusicDuration = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRandomSrart = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(557, 251);
            this.listBox1.TabIndex = 0;
            // 
            // bSelectFolder
            // 
            this.bSelectFolder.Location = new System.Drawing.Point(32, 271);
            this.bSelectFolder.Name = "bSelectFolder";
            this.bSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.bSelectFolder.TabIndex = 1;
            this.bSelectFolder.Text = "Выбрать папку";
            this.bSelectFolder.UseVisualStyleBackColor = true;
            this.bSelectFolder.Click += new System.EventHandler(this.bSelectFolder_Click);
            // 
            // bClearList
            // 
            this.bClearList.Location = new System.Drawing.Point(113, 271);
            this.bClearList.Name = "bClearList";
            this.bClearList.Size = new System.Drawing.Size(75, 23);
            this.bClearList.TabIndex = 2;
            this.bClearList.Text = "Отчистить";
            this.bClearList.UseVisualStyleBackColor = true;
            this.bClearList.Click += new System.EventHandler(this.bClearList_Click);
            // 
            // checkBoxAllDirectory
            // 
            this.checkBoxAllDirectory.AutoSize = true;
            this.checkBoxAllDirectory.Location = new System.Drawing.Point(459, 275);
            this.checkBoxAllDirectory.Name = "checkBoxAllDirectory";
            this.checkBoxAllDirectory.Size = new System.Drawing.Size(118, 17);
            this.checkBoxAllDirectory.TabIndex = 3;
            this.checkBoxAllDirectory.Text = "Вложенные папки";
            this.checkBoxAllDirectory.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(420, 457);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(502, 457);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 5;
            this.bOk.Text = "Применить";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRandomSrart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxMusicDuration);
            this.groupBox1.Controls.Add(this.comboBoxGameDuration);
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxGameDuration
            // 
            this.comboBoxGameDuration.FormattingEnabled = true;
            this.comboBoxGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90",
            "105"});
            this.comboBoxGameDuration.Location = new System.Drawing.Point(163, 16);
            this.comboBoxGameDuration.Name = "comboBoxGameDuration";
            this.comboBoxGameDuration.Size = new System.Drawing.Size(46, 21);
            this.comboBoxGameDuration.TabIndex = 0;
            // 
            // comboBoxMusicDuration
            // 
            this.comboBoxMusicDuration.FormattingEnabled = true;
            this.comboBoxMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.comboBoxMusicDuration.Location = new System.Drawing.Point(163, 42);
            this.comboBoxMusicDuration.Name = "comboBoxMusicDuration";
            this.comboBoxMusicDuration.Size = new System.Drawing.Size(46, 21);
            this.comboBoxMusicDuration.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Продолжительность игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время на ответ";
            // 
            // checkBoxRandomSrart
            // 
            this.checkBoxRandomSrart.AutoSize = true;
            this.checkBoxRandomSrart.Location = new System.Drawing.Point(7, 75);
            this.checkBoxRandomSrart.Name = "checkBoxRandomSrart";
            this.checkBoxRandomSrart.Size = new System.Drawing.Size(127, 17);
            this.checkBoxRandomSrart.TabIndex = 4;
            this.checkBoxRandomSrart.Text = "С случайного места";
            this.checkBoxRandomSrart.UseVisualStyleBackColor = true;
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.checkBoxAllDirectory);
            this.Controls.Add(this.bClearList);
            this.Controls.Add(this.bSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "fParam";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bSelectFolder;
        private System.Windows.Forms.Button bClearList;
        private System.Windows.Forms.CheckBox checkBoxAllDirectory;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxRandomSrart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMusicDuration;
        private System.Windows.Forms.ComboBox comboBoxGameDuration;
    }
}