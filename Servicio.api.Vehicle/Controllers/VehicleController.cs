using Microsoft.AspNetCore.Mvc;
using Servicio.api.Vehicle.Core.Entities;
using Servicio.api.Vehicle.Core.Repository;
using Servicio.api.Vehicle.Helpers;

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
        try
        {
            var rta = await vehicleRepository.GetAll();
            return Ok(rta);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<VehicleEntity>> GetById(string Id)
    {
        try
        {
            var rta = await vehicleRepository.GetById(Id);
            if (rta == null)
            {
                return NotFound();
            }
            return Ok(rta);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpPost]
    public async Task<IActionResult> Create(VehicleEntity vehicle)
    {
        try
        {
            await vehicleRepository.InsertDocument(vehicle);
            return Ok();
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpPost("pagination")]
    public async Task<ActionResult<PaginationEntity<VehicleEntity>>> PostPagination(PaginationEntity<VehicleEntity> pagination)
    {

        try
        {
            var rta = await vehicleRepository.PaginationByFilter(
            pagination
            );

            return Ok(rta);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }



    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string Id, VehicleEntity vehicle)
    {
        if (Id != vehicle.Id)
        {
            return BadRequest("Vehicle id does not match.");
        }

        try
        {
            vehicle.Id = Id;
            await vehicleRepository.UpdateDocument(vehicle);

            return Ok();
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string Id)
    {

        try
        {
            var rta = await vehicleRepository.GetById(Id);
            if (rta == null)
            {
                return NotFound();
            }
            await vehicleRepository.DeleteDocument(Id);
            return Ok();
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }

    }


}