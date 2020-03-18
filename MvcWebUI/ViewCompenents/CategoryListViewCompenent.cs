using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ViewCompenents
{
    [ViewComponent(Name = "CategoryList")]
    public class CategoryListViewCompenent : ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewCompenent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}
