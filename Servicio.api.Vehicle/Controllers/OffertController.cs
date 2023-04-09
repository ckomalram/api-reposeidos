using Microsoft.AspNetCore.Mvc;
using Servicio.api.Vehicle.Core.Entities;
using Servicio.api.Vehicle.Core.Repository;

namespace Servicio.api.Vehicle.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OffertController : ControllerBase
{
    private readonly IMongoRepository<OffertEntity> offertRepository;

    public OffertController(IMongoRepository<OffertEntity> repository)
    {
        offertRepository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<OffertEntity>>> Get()
    {
        var rta = await offertRepository.GetAll();
        return Ok(rta);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<OffertEntity>> GetById(string Id)
    {
        var rta = await offertRepository.GetById(Id);
        return Ok(rta);
    }

    [HttpPost]
    public async Task Create(OffertEntity offer)
    {
        offer.DateOffer = DateTime.Now;
        await offertRepository.InsertDocument(offer);
    }

    [HttpPost("pagination")]
    public async Task<ActionResult<PaginationEntity<OffertEntity>>> PostPagination(PaginationEntity<OffertEntity> pagination)
    {

        var rta = await offertRepository.PaginationByFilter(
        pagination
        );

        return Ok(rta);

    }

    [HttpPut("{id}")]
    public async Task Update(string Id, OffertEntity offer)
    {
        offer.Id = Id;
        await offertRepository.UpdateDocument(offer);
    }

    [HttpDelete("{id}")]
    public async Task Delete(string Id)
    {
        await offertRepository.DeleteDocument(Id);
    }


}