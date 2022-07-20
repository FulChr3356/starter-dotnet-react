using Microsoft.AspNetCore.Mvc;

namespace starter_dotnet_react.Controllers;

[ApiController]
[Route("[controller]")]
public class LoanApplicationController : ControllerBase
{
    private readonly ILogger<LoanApplicationController> _logger;

    public LoanApplicationController(ILogger<LoanApplicationController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public LoanApplication Get()
    {
      return new LoanApplication();
    }
}
