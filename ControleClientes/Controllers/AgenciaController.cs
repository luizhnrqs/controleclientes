using AutoMapper;
using ControleClientes.Aplicacao.Interfaces;
using ControleClientes.Dominio.Entidades;
using ControleClientes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleClientes.Controllers
{
    public class AgenciaController : Controller
    {
        private readonly IAgenciaApp _agenciaApp;

        public AgenciaController(IAgenciaApp agenciaApp)
        {
            _agenciaApp = agenciaApp;
        }

        // GET: Agencia
        public ActionResult Index()
        {
            var agenciaViewModel = Mapper.Map<IEnumerable<Agencia>, IEnumerable<AgenciaViewModel>>(_agenciaApp.List());

            return View(agenciaViewModel);
        }

        // GET: Agencia/Details/5
        public ActionResult Details(int id)
        {
            var agencia = _agenciaApp.Find(id);
            var agenciaViewModel = Mapper.Map<Agencia, AgenciaViewModel>(agencia);

            return View(agenciaViewModel);
        }
    }
}
