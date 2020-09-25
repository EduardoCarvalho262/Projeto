using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Projeto
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

            SendEmail();
        }

        private void SendEmail()
        {

            try { 
            //Para  enviar  email atráves de um windows forms tem que usar
            //System.Net.Mail
            MailMessage message = new MailMessage();

            //Aqui colocamos o "PARA" campo do formulário
            message.To.Add(txtPara.Text);

            //Aqui adicionamos o DE
            message.CC.Add(txtDe.Text);

            //Namesspace Attachments que permite adicionar um anexo
            Attachment anexo = new Attachment(txtFicheiro.Text);
            message.Attachments.Add(anexo);

            //Assunto do email
            message.Subject = txtAssunto.Text;

            //Endereço de email da pessoa que vai enviar ele
            message.From = new MailAddress("eduardoc313@gmail.com");

            //Corpo do email
            message.Body = txtMensagem.Text;

            //Instancia de um smtp
            SmtpClient smtp = new SmtpClient();

            //Definição do Host do smtp
            smtp.Host = "smtp.gmail.com";

            //Se for Gmail isso deve ser true
            smtp.EnableSsl = true;

            //Definição da Porta 
            smtp.Port = 587;

            //Desabilitar as credenciais padrões
            smtp.UseDefaultCredentials = false;

            //Definição das credenciais a serem usadas
            //Lembrando que o acesso de segunraça do google deve estar habilitado
            smtp.Credentials = new System.Net.NetworkCredential("eduardoc313@gmail.com", "SAOPAULO");

            smtp.Send(message);

            MessageBox.Show("Email enviado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFicheiro.Text = openFileDialog1.FileName;
        }
    }

}
