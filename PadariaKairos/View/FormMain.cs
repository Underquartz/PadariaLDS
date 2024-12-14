using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PadariaKairos.View;

namespace PadariaKairos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconMaximizar.Visible = false;
            iconDesmaximizar.Visible = true;
        }

        private void iconDesmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconMaximizar.Visible = true;
            iconDesmaximizar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void abrirFormPainelFill(object form)
        {
            if (this.panelFill.Controls.Count > 0)
                this.panelFill.Controls.RemoveAt(0);
            {
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panelFill.Controls.Add(f);
                this.panelFill.Tag = f;
                f.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormPainelFill(new FormProdutos());
        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque formEstoque = new FormEstoque();
            abrirFormPainelFill(formEstoque);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.panelLeft.Width == 312)
            {
                panelLeft.Width = 84;
            }
            else
                panelLeft.Width = 312;

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            abrirFormPainelFill(formPedido);
        }
    }
}
