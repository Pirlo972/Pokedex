using Pokedex.Domain.Enum.EnumGender;

namespace Pokedex.Domain.Model;
public class User
{
    public int Id { get; set; }
    public required string LastName { get; set; }
    public required string FirstName { get; set; }
    public required Gender Gender { get; set; }
    public required string City { get; set; }
}
