namespace PadariaKairos
{
    partial class FormPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 189);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(220, 50);
            label1.Name = "label1";
            label1.Size = new Size(607, 85);
            label1.TabIndex = 0;
            label1.Text = "Faca um Pedido!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(497, 55);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label2.Location = new Point(35, 280);
            label2.Name = "label2";
            label2.Size = new Size(167, 47);
            label2.TabIndex = 2;
            label2.Text = "Produto";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(297, 535);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(497, 56);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label3.Location = new Point(35, 535);
            label3.Name = "label3";
            label3.Size = new Size(209, 47);
            label3.TabIndex = 4;
            label3.Text = "Categoria";
            // 
            // panel3
            // 
            panel3.Location = new Point(35, 656);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 10);
            panel3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            label4.Location = new Point(35, 407);
            label4.Name = "label4";
            label4.Size = new Size(230, 47);
            label4.TabIndex = 7;
            label4.Text = "Quantidade";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(297, 407);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(497, 55);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            label5.Location = new Point(119, 833);
            label5.Name = "label5";
            label5.Size = new Size(419, 63);
            label5.TabIndex = 9;
            label5.Text = "Total a Pagar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            label6.Location = new Point(544, 833);
            label6.Name = "label6";
            label6.Size = new Size(167, 63);
            label6.TabIndex = 10;
            label6.Text = "00,00";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 942);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "FormPedido";
            Text = "FormPedido";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
    }
}