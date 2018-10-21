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
    public class TipoContaController : Controller
    {
        private readonly ITipoContaApp _tipoContaApp;

        public TipoContaController(ITipoContaApp tipoContaApp)
        {
            _tipoContaApp = tipoContaApp;
        }

        // GET: TipoConta
        public ActionResult Index()
        {
            var tipoContaviewModel = Mapper.Map<IEnumerable<TipoConta>, IEnumerable<TipoContaViewModel>>(_tipoContaApp.List());

            return View(tipoContaviewModel);
        }

        // GET: TipoConta/Details/5
        public ActionResult Details(int id)
        {
            var tipoConta = _tipoContaApp.Find(id);
            var tipoContaViewModel = Mapper.Map<TipoConta, TipoContaViewModel>(tipoConta);

            return View(tipoContaViewModel);
        }
    }
}
