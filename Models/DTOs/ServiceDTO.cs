using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutorial8.Services;

namespace Tutorial8.Models.DTOs;

public class ServiceDTO
{
    public int ServiceId { get; set; }
    public string Name { get; set; }
    public decimal BaseFee { get; set; }

    public ICollection<VisitService> VisitServices { get; set; }
}