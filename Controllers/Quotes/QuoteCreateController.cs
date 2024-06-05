using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Quotes;

namespace Prueba_Desemp.Controllers.Quotes;

[ApiController]
[Route("api/v1/[controller]")]
public class QuoteCreateController : ControllerBase
{
    
    private readonly IQuotesRespository _quotesRespository;
    
    public QuoteCreateController(IQuotesRespository quotesRespository)
    {
        _quotesRespository = quotesRespository;
    }
    
    [HttpPost]
    public IActionResult CreateQuote([FromBody] MyQuote quote)
    {
        _quotesRespository.AddQuotes(quote);
        return Ok();
    }
    
}