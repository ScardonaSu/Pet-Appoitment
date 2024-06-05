using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Vets;

namespace Prueba_Desemp.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class VetDeleteController: ControllerBase
{
    private readonly IVetsRespository _vetsRespository;

    public VetDeleteController(IVetsRespository vetsRespository)
    {
        _vetsRespository = vetsRespository;
    }
    
    [HttpDelete ("{id}")]
    public IActionResult DeleteVet(Vet id)
    {
        _vetsRespository.DeleteVet(id);
        return Ok();
    }
    
    
    

}