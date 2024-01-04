namespace TaiXiu
{
    partial class Laylaimatkhau
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
            textBox1 = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new Krypton.Toolkit.KryptonTextBox();
            button1 = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.CueHint.CueHintText = "Email xác nhận";
            textBox1.Location = new Point(93, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 39);
            textBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox1.StateCommon.Border.Rounding = 18F;
            textBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(93, 146);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 19;
            label3.Text = "Reset Pasword";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 201);
            label4.Name = "label4";
            label4.Size = new Size(363, 20);
            label4.TabIndex = 20;
            label4.Text = "Nhập Email liên kết với tài khoản để nhận lại Pasword";
            // 
            // textBox2
            // 
            textBox2.CueHint.CueHintText = "Mật khẩu sẽ nhận";
            textBox2.Location = new Point(93, 322);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(363, 39);
            textBox2.StateCommon.Back.Color1 = Color.Silver;
            textBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox2.StateCommon.Border.Rounding = 18F;
            textBox2.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(201, 418);
            button1.Name = "button1";
            button1.OverrideDefault.Back.Color1 = Color.DarkOrchid;
            button1.OverrideDefault.Back.Color2 = Color.DarkOrchid;
            button1.Size = new Size(136, 48);
            button1.StateCommon.Back.Color1 = Color.DarkOrchid;
            button1.StateCommon.Back.Color2 = Color.DarkViolet;
            button1.StateCommon.Border.Color1 = Color.DarkOrchid;
            button1.StateCommon.Border.Color2 = Color.DarkOrchid;
            button1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            button1.StateCommon.Border.Rounding = 10F;
            button1.StateCommon.Content.ShortText.Color1 = Color.White;
            button1.StateCommon.Content.ShortText.Color2 = Color.White;
            button1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.TabIndex = 22;
            button1.Values.Text = "Lấy lại";
            button1.Click += button1_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.sendemail;
            kryptonPictureBox1.Location = new Point(96, 22);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(147, 121);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            kryptonPictureBox1.TabIndex = 23;
            kryptonPictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(525, 35);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 24;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Laylaimatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources.reset;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(678, 542);
            Controls.Add(button2);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Name = "Laylaimatkhau";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox textBox1;
        private Label label3;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox textBox2;
        private Krypton.Toolkit.KryptonButton button1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Button button2;
    }
}