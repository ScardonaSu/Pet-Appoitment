using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Pets;

namespace Prueba_Desemp.Controllers.Pet;

[ApiController]
[Route("api/v1/[controller]")]
public class PetCreateController: ControllerBase
{

    private readonly IPetsRespository _petsRespository;
    
    public PetCreateController(IPetsRespository petsRespository)
    {
        _petsRespository = petsRespository;
    }

    [HttpPost]
    public IActionResult CreatePet([FromBody] MyPet pet)
    {
        _petsRespository.AddPet(pet);
        return Ok();
    }

}