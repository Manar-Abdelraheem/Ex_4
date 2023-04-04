using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ex_4.Model;

namespace ex_4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        //private readonly IHttpClientFactory _httpClientFactory;
        //public IndexModel(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;
        public Recipe? Recipe { get; set; } = default!;
       
        public void OnGet()
        {

        }
    }
}