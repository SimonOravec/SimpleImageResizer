namespace imgresizer
{
    partial class app
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
            this.openfile_dialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_selectfile = new System.Windows.Forms.Button();
            this.img_preview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_width = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_resize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.format_selector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.savefile_dialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.img_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // openfile_dialog
            // 
            this.openfile_dialog.Filter = "Image Files|*.JPG;*.JPEG;*.PNG;*.BMP;*.GIF";
            this.openfile_dialog.InitialDirectory = "%HOMEPATH%\\Pictures\\";
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Location = new System.Drawing.Point(12, 12);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(105, 30);
            this.btn_selectfile.TabIndex = 0;
            this.btn_selectfile.Text = "Select file";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // img_preview
            // 
            this.img_preview.Enabled = false;
            this.img_preview.Location = new System.Drawing.Point(12, 268);
            this.img_preview.Name = "img_preview";
            this.img_preview.Size = new System.Drawing.Size(256, 144);
            this.img_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_preview.TabIndex = 1;
            this.img_preview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // input_height
            // 
            this.input_height.Enabled = false;
            this.input_height.Location = new System.Drawing.Point(65, 62);
            this.input_height.Name = "input_height";
            this.input_height.Size = new System.Drawing.Size(73, 22);
            this.input_height.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "px";
            // 
            // input_width
            // 
            this.input_width.Enabled = false;
            this.input_width.Location = new System.Drawing.Point(65, 90);
            this.input_width.Name = "input_width";
            this.input_width.Size = new System.Drawing.Size(73, 22);
            this.input_width.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Width:";
            // 
            // btn_resize
            // 
            this.btn_resize.Enabled = false;
            this.btn_resize.Location = new System.Drawing.Point(15, 163);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(136, 38);
            this.btn_resize.TabIndex = 9;
            this.btn_resize.Text = "Resize and Save";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "© Šimon Oravec 2020";
            // 
            // format_selector
            // 
            this.format_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.format_selector.Enabled = false;
            this.format_selector.FormattingEnabled = true;
            this.format_selector.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "BMP",
            "GIF"});
            this.format_selector.Location = new System.Drawing.Point(120, 119);
            this.format_selector.Name = "format_selector";
            this.format_selector.Size = new System.Drawing.Size(73, 24);
            this.format_selector.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Output format:";
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 424);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.format_selector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_width);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_preview);
            this.Controls.Add(this.btn_selectfile);
            this.Name = "app";
            this.Text = "EZ ImageResizer";
            ((System.ComponentModel.ISupportInitialize)(this.img_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openfile_dialog;
        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.PictureBox img_preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox format_selector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog savefile_dialog;
    }
}

