using SalesWebMvc.Models;
using SalesWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers {
    public class SellersController : Controller {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService) {
            _sellerService = sellerService;
        } // Injeção de dependencia da classe SellerService recebendo as regras do negócio

        public IActionResult Index() {
            var list = _sellerService.FindAll(); // Retornar lista de Seller
            return View(list);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost] // Indentificar que é um método Post ao invés de Get
        [ValidateAntiForgeryToken] // Anotação que para prever exploit de validação invalida via aproveitamento de token
        public IActionResult Create(Seller seller) {
            _sellerService.Insert(seller);
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }

    }
}
