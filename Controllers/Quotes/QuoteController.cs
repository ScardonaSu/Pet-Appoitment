using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Quotes;

namespace Prueba_Desemp.Controllers.Quotes;

[ApiController]
[Route("api/v1/[controller]")]
public class QuoteController: ControllerBase
{
    private readonly IQuotesRespository _quotesRespository;
    
    public QuoteController(IQuotesRespository quotesRespository)
    {
        _quotesRespository = quotesRespository;
    }

    [HttpGet]
    public IEnumerable<MyQuote> GetQuotes()
    {
        return _quotesRespository.GetQuotes();
    }
    
    [HttpGet("{id}")]
    public MyQuote GetQuoteId(int id)
    {
        return _quotesRespository.GetQuoteId(id);
    }
    
    

}