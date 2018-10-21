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
    public class ContaController : Controller
    {
        private readonly IContaApp _contaApp;

        public ContaController(IContaApp contaApp)
        {
            _contaApp = contaApp;
        }

        // GET: Conta
        public ActionResult Index()
        {
            var contaViewModel = Mapper.Map<List<ContaViewModel>>(_contaApp.List().ToList());

            return View(contaViewModel);
        }

        // GET: Conta/Details/5
        public ActionResult Details(int numeroConta)
        {
            var conta = _contaApp.BuscarPorNumeroConta(numeroConta);
            var contaViewModel = Mapper.Map<Conta, ContaViewModel>(conta);

            return View(contaViewModel);
        }
    }
}
