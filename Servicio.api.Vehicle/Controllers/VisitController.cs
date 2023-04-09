using Microsoft.AspNetCore.Mvc;
using Servicio.api.Vehicle.Core.Entities;
using Servicio.api.Vehicle.Core.Repository;

namespace Servicio.api.Vehicle.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VisitController : ControllerBase
{
    private readonly IMongoRepository<VisitEntity> VisitRepository;

    public VisitController(IMongoRepository<VisitEntity> repository)
    {
        VisitRepository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<VisitEntity>>> Get()
    {
        var rta = await VisitRepository.GetAll();
        return Ok(rta);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<VisitEntity>> GetById(string Id)
    {
        var rta = await VisitRepository.GetById(Id);
        return Ok(rta);
    }

    [HttpPost]
    public async Task Create(VisitEntity visit)
    {
        // visit.DateVisit = DateTime.Now;
        await VisitRepository.InsertDocument(visit);
    }

    [HttpPost("pagination")]
    public async Task<ActionResult<PaginationEntity<VisitEntity>>> PostPagination(PaginationEntity<VisitEntity> pagination)
    {

        var rta = await VisitRepository.PaginationByFilter(
        pagination
        );

        return Ok(rta);

    }

    [HttpPut("{id}")]
    public async Task Update(string Id, VisitEntity visit)
    {
        visit.Id = Id;
        await VisitRepository.UpdateDocument(visit);
    }

    [HttpDelete("{id}")]
    public async Task Delete(string Id)
    {
        await VisitRepository.DeleteDocument(Id);
    }


}