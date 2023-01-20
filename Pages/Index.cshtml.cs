using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using AjaxControlToolkit;
using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [Display(Name = "Rating Value"), Required(ErrorMessage = "Rating Value Required")]
        public int RatingValue { get; set; }

        public void OnGet()
        {
            RatingValue = 2;
        }
        public static string Check(double lower, double upper, double toCheck)
        {
            return toCheck > lower && toCheck <= upper ? " checked=\"checked\"" : null;
        }
    }

}