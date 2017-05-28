using _3DotsOfficialWebsite.EmailHandler;
using _3DotsOfficialWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3DotsOfficialWebsite.Controllers
{
    public class HomeController : Controller
    {
        EmailSender email = new EmailSender();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products(int? Id = null)
        {
            if(Id!=null) // Produto especificado através de outra página, para já iniciar com o collapse aberto nele
            {
                ViewBag.ProdutoId = "collapse" + Convert.ToString(Id);
            }

            ViewBag.Message = "Conheça nossas maneiras de potencializar o seu negócio";

            return View();
        }    

        public ActionResult About()
        {
            ViewBag.Message = "Conheça um pouco sobre nós";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tire uma dúvida, solicite um orçamento ou nos convide para um café!";

            return View();
        }


        [HttpPost]
        public ActionResult Contact(PotentialClient contactRequest)
        {          
            if(ModelState.IsValid)
            {
                Console.Write("valido!");
                email.sendMessage(contactRequest);
                email.sendTemporaryResponse(contactRequest);
                ViewBag.MensagemEnviada = "A sua mensagem foi enviada! Em breve entraremos em contato.";
                //Devolver tela informando que enviou com sucesso, em até 24 horas entraremos em contato
            }
            ViewBag.Message = "Tire uma dúvida, solicite um orçamento ou nos convide para um café!";

            return View();
        }
    }
}