using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration configuration;

        public string Title { get; set; }

        public IndexModel(ILogger<IndexModel> logger,IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
            Title = configuration["StringConnexion"];
            //Console.WriteLine(configuration["StringConnexion"]);
        }

        public void OnGet()
        {
           // ViewData["Title"] = configuration["StringConnexion"];
        }
    }
}