using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Data;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Pets;

namespace Prueba_Desemp.Controllers.Pet;

[ApiController]
[Route("api/v1/[controller]")]
public class PetUpdateController: ControllerBase
{
    private readonly IPetsRespository _petsRespository;
    
    public PetUpdateController(IPetsRespository petsRespository)
    {
        _petsRespository = petsRespository;
    }

    [HttpPut]
    public IActionResult UpdatePet([FromBody] MyPet pet)
    {
        _petsRespository.UpdatePet(pet);
        return Ok();
    }
}