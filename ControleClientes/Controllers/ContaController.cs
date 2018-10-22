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
