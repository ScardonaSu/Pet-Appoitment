using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Services.Pets;
using Prueba_Desemp.Model;

namespace Prueba_Desemp.Controllers.Pet;

[ApiController]
[Route("api/v1/[controller]")]
public class PetController: ControllerBase
{
    private readonly IPetsRespository _petsRespository;
    
    public PetController(IPetsRespository petsRespository)
    {
        _petsRespository = petsRespository;
    }

    [HttpGet]
    public IEnumerable<MyPet> GetPets()
    {
        return _petsRespository.GPets();
    }

    [HttpGet("{id}")]
    public MyPet GetPetId(int id)
    {
        return _petsRespository.GetPetId(id);
    }
}