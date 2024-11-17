using System;

namespace API.Entities;

public class User
{
    // Convention based approach to Entity Framework Core.
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    
}
