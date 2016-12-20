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
            this.RedChange = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileInfo = new System.Windows.Forms.Label();
            this.FileInfo2 = new System.Windows.Forms.Label();
            this.FileInfo3 = new System.Windows.Forms.Label();
            this.FileInfo4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.GreenChange = new System.Windows.Forms.TrackBar();
            this.BlueChange = new System.Windows.Forms.TrackBar();
            this.RGBlabel1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // RedChange
            // 
            this.RedChange.AccessibleDescription = "";
            this.RedChange.AccessibleName = "";
            this.RedChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RedChange.BackColor = System.Drawing.Color.Red;
            this.RedChange.Location = new System.Drawing.Point(184, 607);
            this.RedChange.Maximum = 255;
            this.RedChange.Minimum = -255;
            this.RedChange.Name = "RedChange";
            this.RedChange.Size = new System.Drawing.Size(510, 45);
            this.RedChange.TabIndex = 5;
            this.RedChange.TickFrequency = 510;
            this.RedChange.Visible = false;
            this.RedChange.Scroll += new System.EventHandler(this.RedChange_Scroll);
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
            this.pictureBox1.Size = new System.Drawing.Size(510, 589);
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
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Filters",
            "Blur",
            "Inversion",
            "Color shift"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 128);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 64);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // GreenChange
            // 
            this.GreenChange.AccessibleDescription = "";
            this.GreenChange.AccessibleName = "";
            this.GreenChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GreenChange.BackColor = System.Drawing.Color.Green;
            this.GreenChange.Location = new System.Drawing.Point(700, 607);
            this.GreenChange.Maximum = 255;
            this.GreenChange.Minimum = -255;
            this.GreenChange.Name = "GreenChange";
            this.GreenChange.Size = new System.Drawing.Size(510, 45);
            this.GreenChange.TabIndex = 12;
            this.GreenChange.TickFrequency = 510;
            this.GreenChange.Visible = false;
            this.GreenChange.Scroll += new System.EventHandler(this.GreenChange_Scroll);
            // 
            // BlueChange
            // 
            this.BlueChange.AccessibleDescription = "";
            this.BlueChange.AccessibleName = "";
            this.BlueChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BlueChange.BackColor = System.Drawing.Color.Blue;
            this.BlueChange.Location = new System.Drawing.Point(184, 658);
            this.BlueChange.Maximum = 255;
            this.BlueChange.Minimum = -255;
            this.BlueChange.Name = "BlueChange";
            this.BlueChange.Size = new System.Drawing.Size(510, 45);
            this.BlueChange.TabIndex = 13;
            this.BlueChange.TickFrequency = 510;
            this.BlueChange.Visible = false;
            this.BlueChange.Scroll += new System.EventHandler(this.BlueChange_Scroll);
            // 
            // RGBlabel1
            // 
            this.RGBlabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RGBlabel1.AutoSize = true;
            this.RGBlabel1.Location = new System.Drawing.Point(700, 658);
            this.RGBlabel1.Name = "RGBlabel1";
            this.RGBlabel1.Size = new System.Drawing.Size(56, 13);
            this.RGBlabel1.TabIndex = 14;
            this.RGBlabel1.Text = "RGB color";
            this.RGBlabel1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::LabWork.Properties.Resources.OpenFile1;
            this.pictureBox2.Location = new System.Drawing.Point(700, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(510, 589);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 733);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RGBlabel1);
            this.Controls.Add(this.BlueChange);
            this.Controls.Add(this.GreenChange);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.FileInfo4);
            this.Controls.Add(this.FileInfo3);
            this.Controls.Add(this.FileInfo2);
            this.Controls.Add(this.FileInfo);
            this.Controls.Add(this.RedChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApplyFilter);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "Graphics editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FileInfo;
        private System.Windows.Forms.Label FileInfo2;
        private System.Windows.Forms.Label FileInfo3;
        private System.Windows.Forms.Label FileInfo4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.TrackBar RedChange;
        public System.Windows.Forms.TrackBar GreenChange;
        public System.Windows.Forms.TrackBar BlueChange;
        private System.Windows.Forms.Label RGBlabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

