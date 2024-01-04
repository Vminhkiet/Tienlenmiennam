namespace TaiXiu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            listView2 = new ListView();
            textBox2 = new Krypton.Toolkit.KryptonTextBox();
            btnsend = new FontAwesome.Sharp.IconButton();
            richTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new Krypton.Toolkit.KryptonTextBox();
            textBox3 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(215, 91);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 43);
            button1.TabIndex = 0;
            button1.Text = "Chơi ngay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(215, 242);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(175, 41);
            button2.TabIndex = 1;
            button2.Text = "Thoát game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(215, 141);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(175, 43);
            button3.TabIndex = 2;
            button3.Text = "Tạo bàn";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(215, 192);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(175, 43);
            button4.TabIndex = 3;
            button4.Text = "Chọn bàn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(536, 14);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(118, 38);
            button5.TabIndex = 4;
            button5.Text = "Đăng xuất";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.emptyava;
            pictureBox1.Location = new Point(13, 5);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(435, 70);
            listView2.Margin = new Padding(4, 3, 4, 3);
            listView2.Name = "listView2";
            listView2.Size = new Size(9, 9);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // textBox2
            // 
            textBox2.CueHint.CueHintText = "Chat here";
            textBox2.Location = new Point(455, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 36);
            textBox2.StateCommon.Back.Color1 = Color.DarkGray;
            textBox2.StateCommon.Border.Color1 = Color.DarkGray;
            textBox2.StateCommon.Border.Color2 = Color.DarkGray;
            textBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox2.StateCommon.Border.Rounding = 8F;
            textBox2.TabIndex = 14;
            textBox2.Click += textBox2_Click;
            // 
            // btnsend
            // 
            btnsend.BackColor = Color.Transparent;
            btnsend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnsend.IconColor = Color.Black;
            btnsend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsend.IconSize = 30;
            btnsend.Location = new Point(616, 274);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(38, 33);
            btnsend.TabIndex = 15;
            btnsend.Text = "iconButton1";
            btnsend.UseVisualStyleBackColor = false;
            btnsend.Click += btnsend_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(455, 91);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(199, 177);
            richTextBox1.StateCommon.Back.Color1 = Color.Silver;
            richTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            richTextBox1.StateCommon.Border.Rounding = 10F;
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 192);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 18;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 128, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Music;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(616, 55);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(35, 35);
            iconButton1.TabIndex = 19;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 36);
            textBox1.StateCommon.Back.Color1 = SystemColors.Info;
            textBox1.StateCommon.Border.ColorAngle = 8F;
            textBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox1.StateCommon.Border.Rounding = 8F;
            textBox1.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 36);
            textBox3.StateCommon.Back.Color1 = SystemColors.Info;
            textBox3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox3.StateCommon.Border.Rounding = 8F;
            textBox3.TabIndex = 21;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AcceptButton = btnsend;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 342);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnsend);
            Controls.Add(textBox2);
            Controls.Add(listView2);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private ListView listView2;
        private Krypton.Toolkit.KryptonTextBox textBox2;
        private FontAwesome.Sharp.IconButton btnsend;
        private Krypton.Toolkit.KryptonRichTextBox richTextBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Krypton.Toolkit.KryptonTextBox textBox1;
        private Krypton.Toolkit.KryptonTextBox textBox3;
    }
}