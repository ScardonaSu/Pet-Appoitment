using Prueba_Desemp.Data;
using Prueba_Desemp.Model;

namespace Prueba_Desemp.Services.Pets;

public class PetsRespository : IPetsRespository
{
    
    private readonly BaseContext _baseContext;
    public PetsRespository(BaseContext context)
    {
        _baseContext = context;
    }

    public IEnumerable<MyPet> GPets()
    {
        return _baseContext.pets.ToList();
    }

    public MyPet GetPetId(int id)
    {
        return _baseContext.pets.Find(id);
    }

    public void AddPet(MyPet pet)
    {
        _baseContext.pets.Add(pet);
        _baseContext.SaveChanges();
    }

    public void UpdatePet(MyPet pet)
    {
        _baseContext.pets.Update(pet);
        _baseContext.SaveChanges();
    }

    
    

}