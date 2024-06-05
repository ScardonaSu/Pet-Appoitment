using Prueba_Desemp.Data;
using Prueba_Desemp.Model;
namespace Prueba_Desemp.Services.Owner;

public class OwnerRepository : IOwnerRepository
{
    public readonly BaseContext _BaseContext;
    
    public OwnerRepository(BaseContext baseContext)
    {
        _BaseContext = baseContext;
    }

    public IEnumerable<MyOwner> GetOwners()
    {
        return _BaseContext.owners.ToList();
    }

    public MyOwner GetOwnerId(int id)
    {
        return _BaseContext.owners.Find(id);
    }

    public void AddOwner(MyOwner owner)
    {
        _BaseContext.owners.Add(owner);
        _BaseContext.SaveChanges();
    }
    
    public void UpdateOwner(MyOwner owner)
    {
        _BaseContext.owners.Update(owner);
        _BaseContext.SaveChanges();
    }
    
    
    
    



}