using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadGAP
{
    public partial class FormEnviarComentarios : Form
    {
        public FormEnviarComentarios()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtNome.Text == null)
            {
                MessageBox.Show("O Campo 'Nome' é obrigatório.");
                txtNome.Select();
                return;
            }

            if (!ValidarEmail(txtEmail.Text)) return;

            if (txtMensagem.Text == "" || txtMensagem.Text == null)
            {
                MessageBox.Show("É preciso inserir uma mensagem para enviar.");
                txtMensagem.Select();
                return;
            }

            try
            {
                // Enviar email por C#
                SmtpClient cliente = new SmtpClient();
                NetworkCredential credenciais = new NetworkCredential();

                // Definir as configurações do cliente
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;

                // Definir as credenciaid de acesso ao email
                credenciais.UserName = ""; // Usuario do Gmail enviador
                credenciais.Password = ""; // Senha do email enviador

                // Define as credenciais no cliente
                cliente.Credentials = credenciais;

                // Preparar a mensagem para enviar
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress(credenciais.UserName + "@gmail.com");
                mensagem.Subject = "Comentário do Notepad";
                mensagem.IsBodyHtml = true;
                mensagem.Body = "<h2>" + DateTime.Now.ToString() + "</h2> <p>" + txtNome + "</p> <p>" + txtEmail + "</p> <p>" + txtMensagem + "</p>";

                // Enviar a mensagem de email
                if (ValidarEmail(txtEmail.Text))
                {
                    mensagem.To.Add(txtEmail.Text);
                    cliente.Send(mensagem);
                    MessageBox.Show("Mensagem Enviada com Sucesso!");
                }
            }
            catch (Exception)
            {
                Process.Start("mailto:gaplogan@gmail.com?subject=Comentario_do_Notepad&body=" + txtMensagem.Text);
            }

            //https://myaccount.google.com/lesssecureapps = Ativar para conseguir enviar email do gmail sem erro
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarEmail(string email)
        {
            bool resultado = true;

            if (email != "")
            {
                // Verificação do endereço de email
                Regex reg = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");
                if (!reg.IsMatch(email))
                {
                    resultado = false;
                }

                // Verifica se o email tem mais do que um @
                int num_ats = 0;
                foreach (char c in email)
                {
                    if (c == '@')
                    {
                        num_ats++;
                    }
                }

                if (num_ats != 1)
                {
                    resultado = false;
                }

                // Verificar se o email foi validado
                if (!resultado)
                {
                    MessageBox.Show("Email inválido");
                    txtEmail.Select();
                }
            }
            else
            {
                resultado = false;
                MessageBox.Show("O Campo 'Email' é obrigatório");
                txtEmail.Select();
            }

            return resultado;
        }
    }
}
