using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

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
    }
}
