using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Tutorial8.Models.DTOs;

public class VisitDTO
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    
    public int ClientId { get; set; }
    
    public string ClientName { get; set; }
    
    public string ClientLastName { get; set; }
    
    public DateTime ClientDate { get; set; }
    
    public int MechanicId { get; set; }
    
    public string MechanicName { get; set; }
    
    public string MechanicLastName { get; set; }
    
    public string MechanicLicenceNumber { get; set; }
}