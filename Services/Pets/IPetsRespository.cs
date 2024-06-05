using Prueba_Desemp.Model;

namespace Prueba_Desemp.Services.Pets;

public interface IPetsRespository
{
    public IEnumerable<MyPet> GPets();
    public MyPet GetPetId(int id);
    public void AddPet(MyPet pet);
    public void UpdatePet(MyPet pet);
    
    
}