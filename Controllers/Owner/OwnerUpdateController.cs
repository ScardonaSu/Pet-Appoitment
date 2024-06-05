using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Owner;

namespace Prueba_Desemp.Controllers.Owner;


[Route("api/[controller]")]
[ApiController]
public class OwnerUpdateController: ControllerBase
{
    
    private readonly IOwnerRepository _IOwnerRepository;
    
    public OwnerUpdateController(IOwnerRepository IOwnerRepository)
    {
        _IOwnerRepository = IOwnerRepository;
    }

    [HttpPut]
    public IActionResult UpdateOwner([FromBody] MyOwner owner)
    {
        _IOwnerRepository.UpdateOwner(owner);
        return Ok();
    }
    
    
}