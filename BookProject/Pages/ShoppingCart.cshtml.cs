using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookProject.Pages
{
    public class ShoppingCartModel : PageModel
    {
        private IBookProjectRepository repo { get; set; }

        public ShoppingCartModel (IBookProjectRepository temp)
        {
            repo = temp;
        }

        public Basket basket { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
