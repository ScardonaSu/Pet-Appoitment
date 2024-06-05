using Prueba_Desemp.Model;
namespace Prueba_Desemp.Services.Owner;

public interface IOwnerRepository
{
    public IEnumerable<MyOwner> GetOwners();
    public MyOwner GetOwnerId(int id);
    public void AddOwner(MyOwner owner);
    public void UpdateOwner(MyOwner owner);
}