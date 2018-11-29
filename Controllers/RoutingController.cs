using Microsoft.AspNetCore.Mvc;

namespace portfolio
{
  public class RoutingController : Controller
  {
    [HttpGet]
    [Route("")]
    public string index()
    {
    return "This is my index";
    }

    [HttpGet]
    [Route("/projects")]
    public string projects()
    {
      return "these are my projects";
    }

    [HttpGet]
    [Route("/contact")]
    public string contact()
    {
      return "this is my contact";
    }

  }
}

