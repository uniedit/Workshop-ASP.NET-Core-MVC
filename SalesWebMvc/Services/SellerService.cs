using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services {
    public class SellerService {

        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context) {
            _context = context;
        }

        public List<Seller> FindAll() { // Operação síncrona por enquanto
            return _context.Seller.ToList(); // Retora tudo da classe Seller (DB) e converte pra uma lista
        }

        public void Insert(Seller obj) {
            obj.Department = _context.Department.First(); // Provisio
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
