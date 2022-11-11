using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MFRA.model;

namespace MFRA.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Person> Personer { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Personer = new List<Person>();
            Personer.Add(new Person("Peter", "22334455"));
            Personer.Add(new Person("Jakob", "22459033"));
            Personer.Add(new Person("Vibeke", "99112455"));

        }
    }
}