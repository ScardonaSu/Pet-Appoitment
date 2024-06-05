using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Quotes;

namespace Prueba_Desemp.Controllers.Quotes;

[ApiController]
[Route("api/v1/[controller]")]
public class QuoteUpdateController : ControllerBase
{
    private readonly IQuotesRespository _quotesRespository;
    
    public QuoteUpdateController(IQuotesRespository quotesRespository)
    {
        _quotesRespository = quotesRespository;
    }

    [HttpPut]
    public IActionResult UpdateQuote([FromBody] MyQuote quote)
    {
        _quotesRespository.UpdateQuotes(quote);
        return Ok();
    }
    
}