using AutoMapper;
using ControleClientes.Aplicacao.Interfaces;
using ControleClientes.Dominio.Entidades;
using ControleClientes.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ControleClientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteApp _clienteApp;

        public ClienteController(IClienteApp clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.List());

            return View(clienteViewModel);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.Find(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var _clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);

                _clienteApp.Add(_clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.Find(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var _clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);

                _clienteApp.Update(_clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.Find(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var _clienteDomain = _clienteApp.Find(id);
            _clienteApp.Remove(_clienteDomain);

            return RedirectToAction("Index");
        }
    }
}
