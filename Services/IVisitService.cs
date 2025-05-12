using Tutorial8.Models.DTOs;

namespace Tutorial8.Services;

public interface IVisitService
{
    Task<VisitDTO> GetVisit(int visitId);
}