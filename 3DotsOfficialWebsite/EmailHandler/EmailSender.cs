using _3DotsOfficialWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace _3DotsOfficialWebsite.EmailHandler
{
    //TODO: Essa classe deve ficar em uma API 
    public class EmailSender
    {
        MailMessage mail;
        SmtpClient client;

        public EmailSender()
        {
            client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("franjote1@gmail.com", "386557688,");
            client.EnableSsl = true;
        }

        public void sendMessage(PotentialClient contactRequest)
        {
            mail = new MailMessage("franjote1@gmail.com", "franjote1@gmail.com");
            mail.Subject = "3Dots contato: " + contactRequest.name;
            mail.Body = "Nome " + contactRequest.name +
                "; Email: " + contactRequest.email +
                "; Empresa: " + contactRequest.company +
                "; Telefone: " + contactRequest.phone +
                "; Mensagem: " + contactRequest.message;

            doInternalMessageSend(mail);
        }

        public void sendTemporaryResponse(PotentialClient contactRequest)
        {
            mail = new MailMessage("franjote1@gmail.com", contactRequest.email);
            mail.Subject = "3Dots - Contato";
            mail.Body = "Olá " + contactRequest.name + ", tudo bem? " + "Obrigado pelo seu contato através do site www.3dots.com ! Iremos responder a sua solicitação em no máximo 24 horas.";
            doInternalMessageSend(mail);
        }

        private void doInternalMessageSend(MailMessage mail)
        {
            try
            {
                client.Send(mail);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}