using System.Web.Mvc;
using SeuProjeto.Models;

namespace SeuProjeto.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                return View("Confirmacao", aluno);
            }

            return View(aluno);
        }
    }
}