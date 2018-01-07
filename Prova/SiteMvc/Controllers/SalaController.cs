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
    public class SalaController : Controller
    {
        // GET: Sala
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var dominio = new Sala();
                    var salas = dominio.GerarSalas(file.InputStream);
                    return View("Index", new GerarSalaViewModel { Salas = ConvertToModel(salas) });
                }
            }
            return RedirectToAction("Index", "Home");
        }

        private List<SalaViewModel> ConvertToModel(List<SalaValueObject> salas)
        {
            return (from sala in salas
                    select new SalaViewModel
                    {
                        Alunos = ConvertToModel(sala.Alunos)
                    }).ToList();
        }

        private List<AlunoViewModel> ConvertToModel(List<AlunoValueObject> alunos)
        {
            return (from aluno in alunos
                    select new AlunoViewModel
                    {
                        NomeCompleto = aluno.NomeCompleto,
                        Sexo = aluno.Sexo,
                        Afinidade = aluno.Afinidade
                    }).ToList();
        }
    }
}