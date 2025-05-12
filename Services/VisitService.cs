using Microsoft.Data.SqlClient;
using Tutorial8.Models.DTOs;

namespace Tutorial8.Services;

public class VisitService : IVisitService
{
    private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=APBD;Integrated Security=True;";
    
    VisitDTO result;
    public async Task<VisitDTO> GetVisit(int visitId)
    {
        string command = "SELECT v.visit_id, v.date, c.client_id, c.first_name, c.last_name, c.date_of_birth, m.mechanic_id, m.first_name, m.last_name, m.licence_number FROM Client c INNER JOIN  Visit v on c.client_id = v.clientid INNER JOIN Mechanic m ON m.mechanic_id = v.mechanicid WHERE c.visit_id = @visitId ";
        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(command, conn))
        {
            cmd.Parameters.AddWithValue("@visitId", visitId);
            await conn.OpenAsync();

            using (var reader = await cmd.ExecuteReaderAsync())
            {
                int idOrdinal = reader.GetOrdinal("visit_id");
                result = new VisitDTO
                {
                    Id = reader.GetInt32(idOrdinal),
                    Date = reader.GetDateTime(1),
                    ClientId = reader.GetInt32(2),
                    ClientName = reader.GetString(3),
                    ClientLastName = reader.GetString(4),
                    ClientDate = reader.GetDateTime(5),
                    MechanicId = reader.GetInt32(6),
                    MechanicName = reader.GetString(7),
                    MechanicLastName = reader.GetString(8),
                    MechanicLicenceNumber = reader.GetString(9)
                };
            }
        }
        return result;
    }
}