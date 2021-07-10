using BethanysPieShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace BethanysPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string Category { get; set; }
    }
}
