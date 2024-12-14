namespace PadariaKairos
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelLeft = new Panel();
            button1 = new Button();
            btnEstoque = new Button();
            btnPedidos = new Button();
            btnProdutos = new Button();
            pictureBox2 = new PictureBox();
            panelTop = new Panel();
            iconMaximizar = new PictureBox();
            iconDesmaximizar = new PictureBox();
            iconMinimizar = new PictureBox();
            iconFechar = new PictureBox();
            pictureBox1 = new PictureBox();
            panelFill = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconDesmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Chocolate;
            panelLeft.Controls.Add(button1);
            panelLeft.Controls.Add(btnEstoque);
            panelLeft.Controls.Add(btnPedidos);
            panelLeft.Controls.Add(btnProdutos);
            panelLeft.Controls.Add(pictureBox2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(312, 1002);
            panelLeft.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(9, 783);
            button1.Name = "button1";
            button1.Size = new Size(348, 102);
            button1.TabIndex = 3;
            button1.Text = "Usuarios";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            btnEstoque.BackgroundImageLayout = ImageLayout.Zoom;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = SystemColors.ControlLightLight;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.TopLeft;
            btnEstoque.Location = new Point(6, 440);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(351, 120);
            btnEstoque.TabIndex = 1;
            btnEstoque.Text = "Gerenciar Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidos.ForeColor = SystemColors.ControlLightLight;
            btnPedidos.Image = (Image)resources.GetObject("btnPedidos.Image");
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(9, 614);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(348, 102);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Gerenciar Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackgroundImageLayout = ImageLayout.Zoom;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = SystemColors.ControlLightLight;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(6, 252);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(351, 138);
            btnProdutos.TabIndex = 0;
            btnProdutos.Text = "Gerenciar Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 222);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ControlLightLight;
            panelTop.Controls.Add(iconMaximizar);
            panelTop.Controls.Add(iconDesmaximizar);
            panelTop.Controls.Add(iconMinimizar);
            panelTop.Controls.Add(iconFechar);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(312, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1934, 159);
            panelTop.TabIndex = 1;
            panelTop.Paint += panel2_Paint;
            panelTop.MouseDown += panel2_MouseDown;
            // 
            // iconMaximizar
            // 
            iconMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaximizar.Image = (Image)resources.GetObject("iconMaximizar.Image");
            iconMaximizar.Location = new Point(1686, 36);
            iconMaximizar.Name = "iconMaximizar";
            iconMaximizar.Size = new Size(90, 84);
            iconMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            iconMaximizar.TabIndex = 4;
            iconMaximizar.TabStop = false;
            iconMaximizar.Click += pictureBox6_Click;
            // 
            // iconDesmaximizar
            // 
            iconDesmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconDesmaximizar.Image = (Image)resources.GetObject("iconDesmaximizar.Image");
            iconDesmaximizar.Location = new Point(1686, 36);
            iconDesmaximizar.Name = "iconDesmaximizar";
            iconDesmaximizar.Size = new Size(90, 84);
            iconDesmaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            iconDesmaximizar.TabIndex = 3;
            iconDesmaximizar.TabStop = false;
            iconDesmaximizar.Click += iconDesmaximizar_Click;
            // 
            // iconMinimizar
            // 
            iconMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimizar.Image = (Image)resources.GetObject("iconMinimizar.Image");
            iconMinimizar.Location = new Point(1544, 36);
            iconMinimizar.Name = "iconMinimizar";
            iconMinimizar.Size = new Size(90, 84);
            iconMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            iconMinimizar.TabIndex = 2;
            iconMinimizar.TabStop = false;
            iconMinimizar.Click += iconMinimizar_Click;
            // 
            // iconFechar
            // 
            iconFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconFechar.Image = (Image)resources.GetObject("iconFechar.Image");
            iconFechar.Location = new Point(1818, 36);
            iconFechar.Name = "iconFechar";
            iconFechar.Size = new Size(90, 84);
            iconFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            iconFechar.TabIndex = 1;
            iconFechar.TabStop = false;
            iconFechar.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelFill
            // 
            panelFill.BackColor = SystemColors.ControlLightLight;
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(312, 159);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(1934, 843);
            panelFill.TabIndex = 2;
            panelFill.Paint += panelFill_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2246, 1002);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconDesmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelTop;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox iconMaximizar;
        private PictureBox iconDesmaximizar;
        private PictureBox iconMinimizar;
        private PictureBox iconFechar;
        private Button btnProdutos;
        private Button btnPedidos;
        private Button btnEstoque;
        private Button button1;
        private Panel panelFill;
    }
}