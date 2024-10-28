namespace API_Spotify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Url = new TextBox();
            label_Search = new Label();
            button_Search = new Button();
            label_TenAlbum = new Label();
            label_CaSi = new Label();
            label1 = new Label();
            pictureBox_CoverArt = new PictureBox();
            label_NamPhatHanh = new Label();
            textBox_TenAlbum = new TextBox();
            textBox_TenCaSi = new TextBox();
            textBox_NamPhatHanh = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CoverArt).BeginInit();
            SuspendLayout();
            // 
            // textBox_Url
            // 
            textBox_Url.Location = new Point(232, 84);
            textBox_Url.Multiline = true;
            textBox_Url.Name = "textBox_Url";
            textBox_Url.Size = new Size(255, 32);
            textBox_Url.TabIndex = 0;
            // 
            // label_Search
            // 
            label_Search.AutoSize = true;
            label_Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Search.Location = new Point(90, 90);
            label_Search.Name = "label_Search";
            label_Search.Size = new Size(136, 20);
            label_Search.TabIndex = 1;
            label_Search.Text = "Nhập tên tìm kiếm";
            // 
            // button_Search
            // 
            button_Search.BackColor = SystemColors.Window;
            button_Search.FlatStyle = FlatStyle.Flat;
            button_Search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Search.Location = new Point(493, 84);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(84, 32);
            button_Search.TabIndex = 2;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = false;
            button_Search.Click += button_Search_Click;
            // 
            // label_TenAlbum
            // 
            label_TenAlbum.AutoSize = true;
            label_TenAlbum.Location = new Point(69, 199);
            label_TenAlbum.Name = "label_TenAlbum";
            label_TenAlbum.Size = new Size(78, 20);
            label_TenAlbum.TabIndex = 3;
            label_TenAlbum.Text = "Tên album";
            // 
            // label_CaSi
            // 
            label_CaSi.AutoSize = true;
            label_CaSi.Location = new Point(69, 244);
            label_CaSi.Name = "label_CaSi";
            label_CaSi.Size = new Size(65, 20);
            label_CaSi.TabIndex = 5;
            label_CaSi.Text = "Tên ca sĩ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(214, 21);
            label1.Name = "label1";
            label1.Size = new Size(301, 31);
            label1.TabIndex = 6;
            label1.Text = "Tìm kiếm thông tin bài hát";
            // 
            // pictureBox_CoverArt
            // 
            pictureBox_CoverArt.Location = new Point(527, 166);
            pictureBox_CoverArt.Name = "pictureBox_CoverArt";
            pictureBox_CoverArt.Size = new Size(174, 181);
            pictureBox_CoverArt.TabIndex = 7;
            pictureBox_CoverArt.TabStop = false;
            // 
            // label_NamPhatHanh
            // 
            label_NamPhatHanh.AutoSize = true;
            label_NamPhatHanh.Location = new Point(69, 282);
            label_NamPhatHanh.Name = "label_NamPhatHanh";
            label_NamPhatHanh.Size = new Size(111, 20);
            label_NamPhatHanh.TabIndex = 8;
            label_NamPhatHanh.Text = "Năm phát hành";
            // 
            // textBox_TenAlbum
            // 
            textBox_TenAlbum.Location = new Point(197, 196);
            textBox_TenAlbum.Name = "textBox_TenAlbum";
            textBox_TenAlbum.ReadOnly = true;
            textBox_TenAlbum.Size = new Size(278, 27);
            textBox_TenAlbum.TabIndex = 9;
            // 
            // textBox_TenCaSi
            // 
            textBox_TenCaSi.Location = new Point(197, 237);
            textBox_TenCaSi.Name = "textBox_TenCaSi";
            textBox_TenCaSi.ReadOnly = true;
            textBox_TenCaSi.Size = new Size(278, 27);
            textBox_TenCaSi.TabIndex = 10;
            // 
            // textBox_NamPhatHanh
            // 
            textBox_NamPhatHanh.Location = new Point(197, 279);
            textBox_NamPhatHanh.Name = "textBox_NamPhatHanh";
            textBox_NamPhatHanh.ReadOnly = true;
            textBox_NamPhatHanh.Size = new Size(278, 27);
            textBox_NamPhatHanh.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 228, 148);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_NamPhatHanh);
            Controls.Add(textBox_TenCaSi);
            Controls.Add(textBox_TenAlbum);
            Controls.Add(label_NamPhatHanh);
            Controls.Add(pictureBox_CoverArt);
            Controls.Add(label1);
            Controls.Add(label_CaSi);
            Controls.Add(label_TenAlbum);
            Controls.Add(button_Search);
            Controls.Add(label_Search);
            Controls.Add(textBox_Url);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_CoverArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Url;
        private Label label_Search;
        private Button button_Search;
        private Label label_TenAlbum;
        private Label label_CaSi;
        private Label label1;
        private PictureBox pictureBox_CoverArt;
        private Label label_NamPhatHanh;
        private TextBox textBox_TenAlbum;
        private TextBox textBox_TenCaSi;
        private TextBox textBox_NamPhatHanh;
    }
}
