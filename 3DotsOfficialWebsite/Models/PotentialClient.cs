using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _3DotsOfficialWebsite.Models
{
    public class PotentialClient
    {
        public int potentialClientId { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage ="Preencha seu nome, por favor")]
        public string name { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Preencha seu email, por favor")]
        [EmailAddress(ErrorMessage = "Verifique seu email, está em um formato inválido")]
        public string email { get; set; }
        [DisplayName("Telefone")]
        public string phone { get; set; }
        [DisplayName("Empresa")]
        public string company { get; set; }
        [Required(ErrorMessage = "No que podemos te ajudar hoje?")]
        [DisplayName("Mensagem")]
        public string message { get; set; }
    }
}