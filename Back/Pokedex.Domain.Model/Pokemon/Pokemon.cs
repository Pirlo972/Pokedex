using Pokedex.Domain.Enum.EnumCategoryPokemon;
using Pokedex.Domain.Enum.EnumGender;
using Pokedex.Domain.Enum.EnumTalentPokemon;
using Pokedex.Domain.Enum.EnumTypePokemon;
using Pokedex.Domain.Enum.EnumWeaknessesPokemon;

namespace Pokedex.Domain.Model;
public class Pokemon
{
    public int Id { get; set; }
    public double Size { get; set; }
    public double Weight { get; set; }
    public Gender Gender { get; set; }
    public CategoryPokemon CategoryPokemon { get; set; }
    public TalentPokemon TalentPokemon { get; set; }
    public TypePokemon TypePokemon { get; set; }
    public WeaknessesPokemon WeaknessesPokemon { get; set; }
    public string Commenatire { get; set; }
}
