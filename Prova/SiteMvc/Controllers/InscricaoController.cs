using Dominio;
using SiteMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValueObjects;

namespace SiteMvc.Controllers
{
    public class InscricaoController : Controller
    {

        // GET: Inscricao
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Salvar(InscricaoViewModel model)
        {
            try
            {
                var dominio = new Inscricao();
                var mensagem = dominio.Salvar(Translate(model));
                if (!string.IsNullOrEmpty(mensagem))
                {
                    ModelState.AddModelError("", mensagem);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Home");
        }

        private InscricaoValueObject Translate(InscricaoViewModel model)
        {
            return new InscricaoValueObject
            {
                firstname = model.firstname,
                cad_cpf = model.cad_cpf,
                cad_datanascimento = Convert.ToDateTime(model.cad_datanascimento),
                emailaddress1 =  model.emailaddress1
            };
        }
    }
}