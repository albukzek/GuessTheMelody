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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(483, 212);
            this.listBox1.TabIndex = 0;
            // 
            // bSelectFolder
            // 
            this.bSelectFolder.Location = new System.Drawing.Point(12, 230);
            this.bSelectFolder.Name = "bSelectFolder";
            this.bSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.bSelectFolder.TabIndex = 1;
            this.bSelectFolder.Text = "Выбрать папку";
            this.bSelectFolder.UseVisualStyleBackColor = true;
            this.bSelectFolder.Click += new System.EventHandler(this.bSelectFolder_Click);
            // 
            // bClearList
            // 
            this.bClearList.Location = new System.Drawing.Point(93, 230);
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
            this.checkBoxAllDirectory.Location = new System.Drawing.Point(207, 234);
            this.checkBoxAllDirectory.Name = "checkBoxAllDirectory";
            this.checkBoxAllDirectory.Size = new System.Drawing.Size(118, 17);
            this.checkBoxAllDirectory.TabIndex = 3;
            this.checkBoxAllDirectory.Text = "Вложенные папки";
            this.checkBoxAllDirectory.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(257, 340);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(339, 340);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 5;
            this.bOk.Text = "Применить";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 419);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.checkBoxAllDirectory);
            this.Controls.Add(this.bClearList);
            this.Controls.Add(this.bSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "fParam";
            this.Text = "Настройки";
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
    }
}