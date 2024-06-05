using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Vets;

namespace Prueba_Desemp.Controllers;


[ApiController]
[Route("api/v1/[controller]")]
public class VetUpdateController : ControllerBase
{
    private readonly IVetsRespository _vetsRespository;
    
    public VetUpdateController(IVetsRespository vetsRespository)
    {
        _vetsRespository = vetsRespository;
    }

    [HttpPut]
    public IActionResult UpdateVet([FromBody] Vet vet)
    {
       _vetsRespository.UpdateVet(vet);
        return Ok();
    }
    
    

}