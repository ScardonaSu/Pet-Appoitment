using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Owner;

namespace Prueba_Desemp.Controllers.Owner;

[ApiController]
[Route("api/v1/[controller]")]
public class OwnerController : ControllerBase
{
    
    private readonly IOwnerRepository _ownerRepository;
    
    public OwnerController(IOwnerRepository ownerRepository)
    {
        _ownerRepository = ownerRepository;
    }

    [HttpGet]
    public IEnumerable<MyOwner> GetOwners()
    {
        return _ownerRepository.GetOwners();
    }

    [HttpGet("{id}")]
    public MyOwner GetOwnerId(int id)
    {
        return _ownerRepository.GetOwnerId(id);
    }
    
    
}