using System.ComponentModel.DataAnnotations;

namespace Tutorial8.Models.DTOs;

public class ClientDTO
{
    public int MechanicId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LicenceNumber { get; set; }
    
}