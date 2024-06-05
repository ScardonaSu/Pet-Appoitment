using Microsoft.AspNetCore.Mvc;
using Prueba_Desemp.Model;
using Prueba_Desemp.Services.Vets;

namespace Prueba_Desemp.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class VetController: ControllerBase
{
    private readonly IVetsRespository _vetsRespository;
    
    public VetController(IVetsRespository vetsRespository)
    {
        _vetsRespository = vetsRespository;
    }

    [HttpGet]
    public IEnumerable<Vet> GetVets()
    {
        return _vetsRespository.GetVets();
    }
    
    [HttpGet("{id}")]
    public Vet GetVetId(int id)
    {
        return _vetsRespository.GetVetId(id);
    }
    
    
    
}