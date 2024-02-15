using Microsoft.AspNetCore.Mvc;

namespace DogViewModel.Controllers
{
    public class Helloworldcontroller : Controller
    {
        public String Index()
        {
            return "This is the Index page"();
        }

        public string Hello()
        {
            return "who's there?";
        }
    }
}
