using ProjetoMVC.Data;
using ProjetoMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoMVC.Services
{
    public class SellerService
    {
        private readonly ProjetoMVCContext _context;

        public SellerService(ProjetoMVCContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
