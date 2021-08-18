using FormatandoDatasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormatandoDatasMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Funcionarios> funcionario = new List<Funcionarios>()
            {
                new Models.Funcionarios
                {
                    DataAdmissao = DateTime.Now,
                    DataNascimento = Convert.ToDateTime("30/04/1982"),
                    Notas = "Teste",
                    Pais = "Brasil",
                    TelefoneResidencial = "(000) 9.9999-9999"
                },
                new Models.Funcionarios
                {
                    DataAdmissao = DateTime.Now,
                    DataNascimento = Convert.ToDateTime("30/04/1982"),
                    Notas = "Teste2",
                    Pais = "Brasil2",
                    TelefoneResidencial = "(000) 9.9999-9999"
                }
            };
            return View(funcionario);
        }
       
        public List<Funcionarios> Lista()
        {
            List<Funcionarios> funcionario = new List<Funcionarios>()
            {
                new Models.Funcionarios
                {
                    DataAdmissao = DateTime.Now,
                    DataNascimento = Convert.ToDateTime("30/04/1982"),
                    Notas = "Teste",
                    Pais = "Brasil",
                    TelefoneResidencial = "(000) 9.9999-9999"
                },
                new Models.Funcionarios
                {
                    DataAdmissao = DateTime.Now,
                    DataNascimento = Convert.ToDateTime("30/04/1982"),
                    Notas = "Teste2",
                    Pais = "Brasil2",
                    TelefoneResidencial = "(000) 9.9999-9999"
                }
            };
            return funcionario;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}