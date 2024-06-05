using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Vets;

namespace Prueba_Desemp.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class VetCreateController : ControllerBase
{
    private readonly IVetsRespository _vetsRespository;
    
    public VetCreateController(IVetsRespository vetsRespository)
    {
        _vetsRespository = vetsRespository;
    }

    [HttpPost]
    public IActionResult VetCreate([FromBody] Vet vet)
    {
        _vetsRespository.AddVet(vet);
        return Ok();
    }

}