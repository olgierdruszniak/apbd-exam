using System.ComponentModel.DataAnnotations;

namespace Tutorial8.Models.DTOs;

public class MechanicDTO
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string FirstName { get; set; }
    
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [MaxLength(14)]
    public string LicenceNumber { get; set; }
}