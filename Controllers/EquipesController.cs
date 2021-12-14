using E_Jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace E_Jogos.Controllers
{
    public class EquipesController : Controller
    {
        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe nova_equipe = Equipe();
            nova_equipe.IdEquipe = int.Parse(form["IdEquipe"]);
            nova_equipe.Name = form["name"];
            nova_equipe.imagem = form["image"];

            equipeModel.Create(nova_equipe);
            ViewBag.Equipes = equipeModel.ReadAll();


            return LocalRedirect("~/Equipes");

        }

        private Equipe Equipe()
        {
            throw new NotImplementedException();
        }
    }
}
