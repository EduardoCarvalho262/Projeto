using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmPrincipal : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = true;
        }

        private void btnDuvidas_Click(object sender, EventArgs e)
        {
            //AbrirFormNoPanel<Duvidas>();
            MetroFramework.Forms.MetroForm metroForm = new Duvidas();
            metroForm.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            // AbrirFormNoPanel<IdeaSobre>();
            MetroFramework.Forms.MetroForm metroForm = new IdeaSobre();
            metroForm.Show();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            //AbrirFormNoPanel<Orcamento>();
            MetroFramework.Forms.MetroForm metroForm = new Orcamento();
            metroForm.Show();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }



       /* private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        } */

       /* private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        } */

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }
    }
}
