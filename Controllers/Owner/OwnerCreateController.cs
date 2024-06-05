using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Owner;

namespace Prueba_Desemp.Controllers.Owner;

[ApiController]
[Route("api/v1/[controller]")]
public class OwnerCreateController: ControllerBase
{
    
    private readonly IOwnerRepository _ownerRepository;
    
    public OwnerCreateController(IOwnerRepository ownerRepository)
    {
        _ownerRepository = ownerRepository;
    }

    [HttpPost]
    public IActionResult CreateOwner([FromBody] MyOwner owner)
    {
        _ownerRepository.AddOwner(owner);
        return Ok();
    }
    
}