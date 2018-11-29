using Microsoft.AspNetCore.Mvc;

namespace portfolio
{
  public class RoutingController : Controller
  {
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
    return View();
    }

    [HttpGet]
    [Route("/projects")]
    public ViewResult projects()
    {
      return View();
    }

    [HttpGet]
    [Route("/contact")]
    public ViewResult Contact()
    {
      return View();
    }

  }
}

