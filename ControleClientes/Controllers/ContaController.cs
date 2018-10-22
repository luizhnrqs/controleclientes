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
        private readonly ITipoContaApp _tipoContaApp;
        private readonly IClienteApp _clienteApp;
        private readonly IAgenciaApp _agenciaApp;

        public ContaController(IContaApp contaApp, ITipoContaApp tipoContaApp, IClienteApp clienteApp, IAgenciaApp agenciaApp)
        {
            _contaApp = contaApp;
            _tipoContaApp = tipoContaApp;
            _clienteApp = clienteApp;
            _agenciaApp = agenciaApp;
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

        // GET: Cliente/Create
        public ActionResult Create()
        {
            ViewBag.TipoContasList = new SelectList(Mapper.Map<List<TipoContaViewModel>>(_tipoContaApp.List().ToList()), "IdTipoConta", "NomeTipoConta");
            ViewBag.ClientesList = new SelectList(Mapper.Map<List<ClienteViewModel>>(_clienteApp.List().ToList()), "IdCliente", "Nome");
            ViewBag.AgenciasList = new SelectList(Mapper.Map<List<AgenciaViewModel>>(_agenciaApp.List().ToList()), "IdAgencia", "NomeAgencia");

            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContaViewModel conta)
        {
            if (ModelState.IsValid)
            {
                var _clienteDomain = Mapper.Map<ContaViewModel, Conta>(conta);

                _contaApp.Add(_clienteDomain);

                return RedirectToAction("Index");
            }

            return View(conta);
        }

        // GET: Conta/Transferir/5
        public ActionResult Transferir(int numeroConta)
        {
            var conta = _contaApp.BuscarPorNumeroConta(numeroConta);
            var contaViewModel = Mapper.Map<Conta, ContaViewModel>(conta);

            var listaContas = _contaApp.List().ToList();
            listaContas.Remove(conta);

            ViewBag.ListaContas = new SelectList(Mapper.Map<List<ContaViewModel>>(listaContas), "NumeroConta", "NumeroContaCliente");

            return View(contaViewModel);
        }

        // POST: Conta/Transferir/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transferir(FormCollection form)
        {
            try
            {
                var numContaOrigem = form["NumeroConta"];
                var numContaDestino = form["ContaDestino"];
                var valor = Convert.ToDouble(form["Valor"]);

                _contaApp.Transferir(numContaOrigem, numContaDestino, valor);

                TempData["Sucesso"] = $"Transferência no valor de {valor} entre a conta {numContaOrigem} e {numContaDestino} realizada com sucesso!";
            }
            catch(Exception ex)
            {
                TempData["Erro"] = ex.Message;
            }

            return RedirectToAction("Index");
        }
    }
}
