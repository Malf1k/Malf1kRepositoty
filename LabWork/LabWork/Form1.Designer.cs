namespace LabWork
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileInfo = new System.Windows.Forms.Label();
            this.FileInfo2 = new System.Windows.Forms.Label();
            this.FileInfo3 = new System.Windows.Forms.Label();
            this.FileInfo4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(12, 41);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Enabled = false;
            this.Clear.Location = new System.Drawing.Point(12, 70);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Enabled = false;
            this.ApplyFilter.Location = new System.Drawing.Point(12, 99);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.ApplyFilter.TabIndex = 4;
            this.ApplyFilter.Text = "ApplyFilter";
            this.ApplyFilter.UseVisualStyleBackColor = true;
            this.ApplyFilter.Click += new System.EventHandler(this.Apply_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleDescription = "";
            this.trackBar1.AccessibleName = "";
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar1.Location = new System.Drawing.Point(184, 607);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(233, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::LabWork.Properties.Resources.OpenFile1;
            this.pictureBox1.Location = new System.Drawing.Point(184, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FileInfo
            // 
            this.FileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileInfo.AutoSize = true;
            this.FileInfo.Location = new System.Drawing.Point(181, 711);
            this.FileInfo.Name = "FileInfo";
            this.FileInfo.Size = new System.Drawing.Size(29, 13);
            this.FileInfo.TabIndex = 7;
            this.FileInfo.Text = "Path";
            // 
            // FileInfo2
            // 
            this.FileInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileInfo2.AutoSize = true;
            this.FileInfo2.Location = new System.Drawing.Point(9, 711);
            this.FileInfo2.Name = "FileInfo2";
            this.FileInfo2.Size = new System.Drawing.Size(38, 13);
            this.FileInfo2.TabIndex = 8;
            this.FileInfo2.Text = "Height";
            // 
            // FileInfo3
            // 
            this.FileInfo3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileInfo3.AutoSize = true;
            this.FileInfo3.Location = new System.Drawing.Point(9, 680);
            this.FileInfo3.Name = "FileInfo3";
            this.FileInfo3.Size = new System.Drawing.Size(35, 13);
            this.FileInfo3.TabIndex = 9;
            this.FileInfo3.Text = "Width";
            // 
            // FileInfo4
            // 
            this.FileInfo4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileInfo4.AutoSize = true;
            this.FileInfo4.Location = new System.Drawing.Point(83, 711);
            this.FileInfo4.Name = "FileInfo4";
            this.FileInfo4.Size = new System.Drawing.Size(39, 13);
            this.FileInfo4.TabIndex = 10;
            this.FileInfo4.Text = "Fotmat";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Blur filter",
            "Inversion filter",
            "Color shift filter"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 128);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 49);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 733);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.FileInfo4);
            this.Controls.Add(this.FileInfo3);
            this.Controls.Add(this.FileInfo2);
            this.Controls.Add(this.FileInfo);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApplyFilter);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "Graphics editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label FileInfo;
        private System.Windows.Forms.Label FileInfo2;
        private System.Windows.Forms.Label FileInfo3;
        private System.Windows.Forms.Label FileInfo4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

