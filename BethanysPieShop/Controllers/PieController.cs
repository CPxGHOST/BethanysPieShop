using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IPieRepository pieRepository;

        public PieController(ICategoryRepository categoryRepository , IPieRepository pieRepository) {
            this.categoryRepository = categoryRepository;
            this.pieRepository = pieRepository;
        }

        public ViewResult List() {

            PieListViewModel viewModel = new PieListViewModel
            {
                Pies = pieRepository.AllPies,
                Category = "Fruit Pies"
            };
            return View(viewModel);
        }
    
    }
}
