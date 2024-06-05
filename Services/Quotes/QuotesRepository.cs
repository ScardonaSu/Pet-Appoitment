using Prueba_Desemp.Data;
using Prueba_Desemp.Model;

namespace Prueba_Desemp.Services.Quotes;

public class QuotesRepository: IQuotesRespository
{
    private readonly BaseContext _baseContext;
    
    public QuotesRepository(BaseContext context)
    {
        _baseContext = context;
    }

    public IEnumerable<MyQuote> GetQuotes()
    {
        return _baseContext.quotes.ToList();
    }

    public MyQuote GetQuoteId(int id)
    {
        return _baseContext.quotes.Find(id);
    }

    public void AddQuotes(MyQuote quote)
    {
        _baseContext.quotes.Add(quote);
        _baseContext.SaveChanges();
    }

    public void UpdateQuotes(MyQuote quote)
    {
        _baseContext.quotes.Update(quote);
        _baseContext.SaveChanges();
    }



    
}