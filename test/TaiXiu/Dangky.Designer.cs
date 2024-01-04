

namespace TaiXiu
{
    partial class Dangky
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new Krypton.Toolkit.KryptonTextBox();
            textBox2 = new Krypton.Toolkit.KryptonTextBox();
            textBox3 = new Krypton.Toolkit.KryptonTextBox();
            textBox4 = new Krypton.Toolkit.KryptonTextBox();
            textBox5 = new Krypton.Toolkit.KryptonTextBox();
            button1 = new Krypton.Toolkit.KryptonButton();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gifregis;
            pictureBox1.Location = new Point(201, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.show;
            pictureBox2.Location = new Point(562, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.show;
            pictureBox3.Location = new Point(562, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(201, 178);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 19;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(201, 223);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 20;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(201, 268);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 21;
            label3.Text = "Xác nhận mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(201, 313);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 22;
            label4.Text = "Họ tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(201, 358);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 23;
            label5.Text = "Email:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(337, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 39);
            textBox1.StateCommon.Back.Color1 = Color.LightGray;
            textBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox1.StateCommon.Border.Rounding = 18F;
            textBox1.StateCommon.Border.Width = 1;
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 204);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(219, 39);
            textBox2.StateCommon.Back.Color1 = Color.LightGray;
            textBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox2.StateCommon.Border.Rounding = 18F;
            textBox2.StateCommon.Border.Width = 1;
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(337, 249);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(219, 39);
            textBox3.StateCommon.Back.Color1 = Color.LightGray;
            textBox3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox3.StateCommon.Border.Rounding = 18F;
            textBox3.StateCommon.Border.Width = 1;
            textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(337, 294);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 39);
            textBox4.StateCommon.Back.Color1 = Color.LightGray;
            textBox4.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox4.StateCommon.Border.Rounding = 18F;
            textBox4.StateCommon.Border.Width = 1;
            textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(337, 339);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 39);
            textBox5.StateCommon.Back.Color1 = Color.LightGray;
            textBox5.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox5.StateCommon.Border.Rounding = 18F;
            textBox5.StateCommon.Border.Width = 1;
            textBox5.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(373, 384);
            button1.Name = "button1";
            button1.OverrideDefault.Back.Color1 = Color.FromArgb(0, 192, 0);
            button1.OverrideDefault.Back.Color2 = Color.FromArgb(0, 192, 0);
            button1.Size = new Size(126, 46);
            button1.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 0);
            button1.StateCommon.Back.Color2 = Color.FromArgb(0, 192, 0);
            button1.StateCommon.Border.Color1 = Color.FromArgb(0, 192, 0);
            button1.StateCommon.Border.Color2 = Color.FromArgb(0, 192, 0);
            button1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            button1.StateCommon.Border.Rounding = 18F;
            button1.StateCommon.Content.ShortText.Color1 = Color.Black;
            button1.StateCommon.Content.ShortText.Color2 = Color.Black;
            button1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.StateTracking.Back.Color1 = Color.Lime;
            button1.StateTracking.Back.Color2 = Color.FromArgb(0, 192, 0);
            button1.TabIndex = 29;
            button1.Values.Text = "Đăng Ký";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(684, 37);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.regi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Dangky";
            Text = "Dangky";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox textBox1;
        private Krypton.Toolkit.KryptonTextBox textBox2;
        private Krypton.Toolkit.KryptonTextBox textBox3;
        private Krypton.Toolkit.KryptonTextBox textBox4;
        private Krypton.Toolkit.KryptonTextBox textBox5;
        private Krypton.Toolkit.KryptonButton button1;
        private Button button2;
    }
}