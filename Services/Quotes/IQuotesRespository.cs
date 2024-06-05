using Prueba_Desemp.Model;

namespace Prueba_Desemp.Services.Quotes;

public interface IQuotesRespository
{
    public IEnumerable<MyQuote> GetQuotes();
    public MyQuote GetQuoteId(int id);
    public void AddQuotes(MyQuote quote);
    public void UpdateQuotes(MyQuote quote);
    
    

}