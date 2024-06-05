using Prueba_Desemp.Model;

namespace Prueba_Desemp.Services.Vets;

public interface IVetsRespository
{
    public IEnumerable<Vet> GetVets();
    public Vet GetVetId(int id);

    public void AddVet(Vet vet);
    public void UpdateVet(Vet vet);
    public void DeleteVet(Vet vet);
}