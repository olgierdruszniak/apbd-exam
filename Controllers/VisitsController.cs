using Microsoft.AspNetCore.Mvc;
using Tutorial8.Models.DTOs;
using Tutorial8.Services;

namespace Tutorial8.Controllers;


[Route("api/[controller]")]
[ApiController]
public class VisitsController : ControllerBase
{
    private readonly VisitService _service;

    public VisitsController(VisitService service)
    {
        _service = service;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetVisit(int id)
    {
        var visit = _service.GetVisit(id);
        
        if(visit == null)
            return NotFound("Visit not found");
        return Ok(visit);
    }

    /*// POST api/service
    [HttpPost]
    public async Task<IActionResult> AddVisit([FromBody] VisitDTO dto)
    {
        var mechanic = await _context.Mechanics.FirstOrDefaultAsync(m => m.LicenceNumber == dto.MechanicLicenceNumber);
        if (mechanic == null)
            return BadRequest("Mechanic not found");

        var visit = new Visit
        {
            VisitId = dto.VisitId,
            ClientId = dto.ClientId,
            MechanicId = mechanic.MechanicId,
            Date = DateTime.Now
        };

        _context.Visits.Add(visit);
        await _context.SaveChangesAsync();

        foreach (var s in dto.Services)
        {
            var service = await _context.Services.FirstOrDefaultAsync(x => x.Name == s.ServiceName);
            if (service != null)
            {
                await _context.Database.ExecuteSqlRawAsync(
                    "INSERT INTO Visit_Service (visit_id, service_id, service_fee) VALUES ({0}, {1}, {2})",
                    visit.VisitId, service.ServiceId, s.ServiceFee);
            }
        }

        return Ok();
    }

    // Tylko do odczytu service_fee
    private class VisitServiceView
    {
        public int VisitId { get; set; }
        public int ServiceId { get; set; }
        public decimal ServiceFee { get; set; }
    }*/
}