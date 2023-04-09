using Microsoft.AspNetCore.Mvc;
using Servicio.api.Vehicle.Core.Entities;
using Servicio.api.Vehicle.Core.Repository;

namespace Servicio.api.Vehicle.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IMongoRepository<VehicleEntity> vehicleRepository;

    public VehicleController(IMongoRepository<VehicleEntity> repository)
    {
        vehicleRepository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<VehicleEntity>>> Get()
    {
        var rta = await vehicleRepository.GetAll();
        return Ok(rta);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<VehicleEntity>> GetById(string Id)
    {
        var rta = await vehicleRepository.GetById(Id);
        return Ok(rta);
    }

    [HttpPost]
    public async Task Create(VehicleEntity vehicle)
    {
        await vehicleRepository.InsertDocument(vehicle);
    }

    [HttpPost("pagination")]
    public async Task<ActionResult<PaginationEntity<VehicleEntity>>> PostPagination(PaginationEntity<VehicleEntity> pagination)
    {

        var rta = await vehicleRepository.PaginationByFilter(
        pagination
        );

        return Ok(rta);

    }

    [HttpPut("{id}")]
    public async Task Update(string Id, VehicleEntity vehicle)
    {
        vehicle.Id = Id;
        await vehicleRepository.UpdateDocument(vehicle);
    }

    [HttpDelete("{id}")]
    public async Task Delete(string Id)
    {
        await vehicleRepository.DeleteDocument(Id);
    }


}