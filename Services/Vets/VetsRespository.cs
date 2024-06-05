using Prueba_Desemp.Data;
using Prueba_Desemp.Model;

namespace Prueba_Desemp.Services.Vets;

public class VetsRespository: IVetsRespository
{

    public readonly BaseContext _BaseContext;
    
    public VetsRespository(BaseContext baseContext)
    {
        _BaseContext = baseContext;
    }

    public IEnumerable<Vet> GetVets()
    {
        return _BaseContext.Vet.ToList();
    }

    public Vet GetVetId(int id)
    {
        return _BaseContext.Vet.Find(id);
    }

    public void AddVet(Vet vet)
    {
        _BaseContext.Vet.Add(vet);
        _BaseContext.SaveChanges();
    }

    public void UpdateVet(Vet vet)
    {
        _BaseContext.Vet.Update(vet);
        _BaseContext.SaveChanges();
    }

    public void DeleteVet(Vet vet)
    {
        _BaseContext.Vet.Remove(vet);
        _BaseContext.SaveChanges();
        
    }

    
    


}